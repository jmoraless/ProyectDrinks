$("#buscar").click(function () {    
    var typeSearch = $("input[type='radio'][name='search']:checked").val() == 'name';
    console.log(typeSearch)
    let url = typeSearch ? "/home/CoctelsByName" : "/home/CoctelsByIngredent"
    let data = typeSearch ? { name: $("#buscarTXT").val() } : { ingredent: $("#buscarTXT").val() };
    console.log();
    $.ajax({
        type: "post",
        url: url,
        contenttype: 'application/json; charset=utf-8',
        data: data,
        async: true,
        cache: false,
        success: function (response) {

            $("#response").html(response);

        },
        error: function (err) {
            console.log(err);
        }
    });
});

function getDetalle(id) {
    $('#sectionDetail').load("/Home/DetailCoctel?id=" + id, function () {
        $("#detailCoctelModal").modal("show");
    });
}

function storage(name, idDrink) {   
    localStorage.setItem(idDrink, name);
}

function favorites() {
    var arrayOfValues = Object.values(localStorage);
    var arrayOfKeys = Object.keys(localStorage);
    
    var html = '';
    for (var i = 0; i < localStorage.length; i++) {
        let name = arrayOfValues[i];
        let idDrink = arrayOfKeys[i];

        html += `
                <div class="row">
                    <div class='col-md-6'>${name}</div>
                    <div class='col-md-6'>
                        <button class='btn btn-primary' onclick=getDetalle(${idDrink})>Ver detalle</button>
                    </div>
                </div>
                <br>`;
    }
    $("#favoritos").html(html);
}