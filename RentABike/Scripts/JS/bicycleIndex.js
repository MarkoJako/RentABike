
$(document).ready(function () {
    $('[data-toggle="tooltip"]').tooltip();

    $('table .delete').on('click', function () {
        var id = $(this).parent().find('#id').val();
        $('#deleteModal #id').val(id);
    });
});