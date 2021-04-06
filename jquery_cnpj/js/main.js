
function consultaCNPJ(){
    var CNPJ_REQUEST = document.getElementById("CNPJ_requested").value;

    $.ajax({
        url: "https://www.receitaws.com.br/v1/cnpj/" + CNPJ_REQUEST,
        type: "GET",
        dataType: 'jsonp',
        success: function(response){

        document.getElementById("CNPJ_response").value = response.cnpj;
        document.getElementById("nome_response").innerHTML = response.nome;
        document.getElementById("fantasia_response").innerHTML = response.fantasia;
        document.getElementById("uf_response").innerHTML = response.uf;
        document.getElementById("municipio_response").innerHTML = response.municipio;
        document.getElementById("cep_response").innerHTML = response.cep;
        document.getElementById("logradouro_response").innerHTML = response.logradouro + ", " + response.numero + " - " + response.bairro;
        document.getElementById("abertura_response").innerHTML = response.abertura;
        document.getElementById("atividade_response").innerHTML = response.atividade_principal[0].text + " (" + response.atividade_principal[0].code + ")";

        }

    })
}

