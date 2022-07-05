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
            null,
            { "width": "10%"},
            { "width": "15%" },
            null,
        ]

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




