/*const { unique } = require("jquery");*/

$(document).ready(function () {

    $('#indexTable').DataTable({
        "scrollY": "500px",
        "scrollX": true,
        "scrollCollapse": true,
        "paging": true,
        "order": [[0, 'desc']],
        columnDefs: [{
            target: 0,
            visible: false,
        }]
    });

    $('#summaryTable').DataTable({
        "paging": false,
        "scrollY": 500,
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




