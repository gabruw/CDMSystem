//$(document).ready(function () {
//    $("#ConfirmarCadastroGuild").click(function () {
//        var nomeGuild = $("#NomeGuild").val();
//        var descricaoGuild = $("#DescricaoGuild").val();

//        var formData = new FormData();
//        formData.append("NomeGuild", nomeGuild);
//        formData.append("DescricaoGuild", descricaoGuild);

//        $.ajax({
//            type: "GET",
//            url: "https://localhost:44349/api/GuildApi",
//            //data: formData,
//            success: function (returned) {
//                alert("Deu");
//            }
//        });
//    });
//});