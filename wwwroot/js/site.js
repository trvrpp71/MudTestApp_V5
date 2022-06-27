/*const { unique } = require("jquery");*/

$(document).ready(function () {

    $('#indexTable').DataTable({
        "scrollY": "500px",
        "scrollX": true,
        "scrollCollapse": true,
        "paging": true,
        "order": [[0, 'desc']],
        "columns": [
            null,
            null,
            null,
            null,
            null,
            { "width": "20px" },
            { "width": "75px" },
            
            null]
    });

        $('#summaryTable').DataTable({
            "paging": false,
            "scrollY": 400,
            dom: 'Bftr',
            buttons: ['excel']
        });

        $('#detailTable').DataTable({
            dom: 'Bftr',
            buttons: ['excel'],
            "paging": false,
            columnDefs: [{
                target: 0,
                visible: false,
            }]
        });


});

function confirmDelete(uniqueId, isDeleteClicked) {
    var deleteSpan = 'deleteSpan_' + uniqueId;
    var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqueId;

    if (isDeleteClicked) {
        $('#' + deleteSpan).hide();
        $('#' + confirmDeleteSpan).show();
    } else {
        $('#' + deleteSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }
}


