$(document).ready(function () {
    $("#bicycleTypes").DataTable();
});


    $(document).ready(function () {
        $("#saveNewType").hide();
          $("#newBicycleTypeBTN").on("click", function () {
            $("#saveNewType").show(1000);
          })
    });
    $(document).ready(function () {
        $('[data-toggle="tooltip"]').tooltip();

        $('table .delete').on('click', function () {
            var id = $(this).parent().find('#id').val();
            $('#deleteModal #id').val(id);
        });
  
    $('table .edit').on('click', function () {
        var id = $(this).parent().find('#id').val();
        var param = { id: id };
        var path = '/BicycleTypes/OnGetFind';
        $.ajax({
            type: 'GET',
            url: path,
            data: param,
            success: function (result) {
                var name = result[0].name;
                var id = result[0].id;
                var inputFieldName = $('#editModalBody #name');
                var inputFieldId = $('.modal-footer #id');
                inputFieldName.val(name);
                inputFieldId.val(id);
            }
        });
    });
    });
