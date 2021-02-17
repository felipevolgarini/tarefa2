$("#cadastrar").click(function (event) {
    event.preventDefault();

    var options = {};

    options.url = "/Home/GerarArvore?entrada=" + $("#entrada").val();
    options.type = "GET";

    options.success = function (data) {
        $("#resultado").html(data);
    };

    options.error = function () {       
        var options = {
            message: "Ops! Você não digitou apenas números inteiros separados por vírgula.",
            title: "Erro",
            buttons: [{ text: 'Ok', style: 'info', close: true }]
        }
        eModal.alert(options);
    };

    $.ajax(options);
});