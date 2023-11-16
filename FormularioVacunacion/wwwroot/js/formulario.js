

    function loaddataTable() {
        $('#container')
        var datos = {
        $.ajax({
            url: "https://localhost:7294/",
            type: 'POST',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            data: {
            },

        }).data(function (data) {
            $('#id').text(2);
        });
        
}



$.ajax({
    type: 'POST',
    url: 'https://localhost:7294/',
    data: {
        container: JSON.stringify(container),
        linias: JSON.stringify(linias)
    },
    contentType: 'application/json',
    success: function (data) {
        if (data.estado) {
            alert('Vacunas administrada correctamente');
            //here we will clear the form
            list = [];
            $('#id').text(2);
            /*$('#orderdetailsItems').empty();*/
        }
        else {
            alert('Error');
        }
        $('#submit').val('Save');
    },
    error: function (error) {
        console.log(error);
        $('#submit').val('Save');
    }
});
