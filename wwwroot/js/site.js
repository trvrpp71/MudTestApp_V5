$(document).ready(function () {
    $('#indexTable').DataTable({
        "scrollY": "450px",
        "scrollX": true,
        "scrollCollapse": true,
        "paging": true,
        "order": [[0,'desc']]
    }),

        $('#summaryTable').DataTable({
            "paging": false,
            "scrollY": 400
        }),

        $('#detailTable').DataTable({
            dom: 'Bfrtip',
            buttons: [
                'copy', 'csv', 'excel', 'pdf', 'print'
            ]
        })


});

