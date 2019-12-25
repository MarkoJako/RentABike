$(document).ready(function () {
    $("#bicycleTypes").DataTable();
});


$(document).ready(function () {
    $("#saveNewType").hide();
    $("#newBicycleTypeBTN").on("click", function () {
        $("#saveNewType").show(1000);
    })

    $(document).ready(function () {
        $('[data-toggle="tooltip"]').tooltip();

        $('table .delete').on('click', function () {
            var id = $(this).parent().find('#id').val();
            $('#deleteModal #id').val(id);
        });
    });
});