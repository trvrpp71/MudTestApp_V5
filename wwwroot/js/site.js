/*const { unique } = require("jquery");*/

$(document).ready(function () {

    $('#indexTable').DataTable({
        "scrollY": "750px",
        "scrollX": true,
        "scrollCollapse": true,
        "paging": true,
        "order": [[0, 'desc']]
    });

    $('#summaryTable').DataTable({
        "paging": false,
        "scrollY": 750,
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




