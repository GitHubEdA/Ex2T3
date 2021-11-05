/*
$('form').on('submit', function () {
    var valor = $('input').val();
    alert(valor);

    $.ajax({
        url: 'https://localhost:44324/tema/index?query=',
        type: 'get'
    }).done(function (response) {
        $("div#contenido").html(response);
    });
);
*/

var i = 1
$("button#aumentar").click(function (e) {
    e.preventDefault();
    $("div#concatenar").append('<input type="text" name="productos[' + i + '].nombre" /><br />')
    i++;
});


