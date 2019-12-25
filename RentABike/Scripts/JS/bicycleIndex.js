//Search box and pagination
$(document).ready(function () {
    $("#bicycles").DataTable();

});

$(document).ready(function () {
    $('[data-toggle="tooltip"]').tooltip();

    $('table .delete').on('click', function () {
        var id = $(this).parent().find('#id').val();
        $('#deleteModal #id').val(id);
    });
});