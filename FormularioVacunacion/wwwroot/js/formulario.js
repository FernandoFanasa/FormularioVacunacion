

function test() {
   funcionando 
}

    function loaddataTable() {
        datatable = $('#table').DataTable({
            
            "ajax": {
                "url": "/CajaFarmacia/CajaFarmacia/upsert?id=2"
            },
            "columns": [
                { "data": "IdPrimario"},
                { "data": "vEmpleado_conServicio" },
                $('#id').text(2),
            ]

        });
    }


