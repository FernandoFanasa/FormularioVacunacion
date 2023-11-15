//let dataTable:
//    $(document).redy(function () {
//        loadDataTable();
//    });

    function loaddataTable() {
        $("container")
            //    "url": "/CajaFarmacia/CajaFarmacia/ObtenerTodos",
        $.ajax({
            url: "/CajaFarmacia/CajaFarmacia/ObtenerTodos",
            type: 'POST',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            data: {},

        }).data(function (data) {
            $("#id").val(data[0].idPrimario);
        });
        
    }
