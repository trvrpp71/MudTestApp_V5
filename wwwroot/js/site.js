﻿$(document).ready(function () {
    $('#indexTable').DataTable({
        "scrollY": "450px",
        "scrollCollapse": true,
        "paging": true,
        "order": [[0,'desc']]
    })
});
