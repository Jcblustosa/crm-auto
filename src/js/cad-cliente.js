$(document).ready(function(){
    $("#content div:nth-child(1)").show();
    $(".abas li:first div").addClass("selected");
    $(".aba").click(function(){
        $(".aba").removeClass("selected");
        $(this).addClass("selected");
        /* var indice = $(this).parent().index();
        indice++;
        $("#content div").hide();
        $("#content div:nth-child("+indice+")").show(); */
    });

    $(".aba").hover(
        function(){$(this).addClass("ativa")},
        function(){$(this).removeClass("ativa")}
    );
});

function AtivaAba(el) {
    
    var nomeElemento = el
    var displayAba = document.getElementById(el).style.display 

    if(nomeElemento == "abaRes"){
        if (document.getElementById("abaRes").style.display == "none"){
            document.getElementById("abaVeiculo").style.display = 'none'
            document.getElementById("abaRes").style.display = 'block'}
        else if(displayAba == "block"){
            document.getElementById("abaVeiculo").style.display = 'none'
        }
    }

    if(nomeElemento == "abaVeiculo"){
        if(document.getElementById("abaVeiculo").style.display == "none"){
            document.getElementById("abaRes").style.display = 'none'
            document.getElementById("abaVeiculo").style.display = 'block'}
        else if(displayAba == "block"){
            document.getElementById("abaRes").style.display = 'none'
        }
    }
};

function validarCNPJ(cnpj) {
    console.log(cnpj);
    cnpj = cnpj.replace(/[^\d]+/g,'');
 
    if(cnpj == '') return false;
     
    if (cnpj.length != 14)
        return false;
 
    // Elimina CNPJs invalidos conhecidos
    if (cnpj == "00000000000000" || 
        cnpj == "11111111111111" || 
        cnpj == "22222222222222" || 
        cnpj == "33333333333333" || 
        cnpj == "44444444444444" || 
        cnpj == "55555555555555" || 
        cnpj == "66666666666666" || 
        cnpj == "77777777777777" || 
        cnpj == "88888888888888" || 
        cnpj == "99999999999999")
        return false;
         
    // Valida DVs
    tamanho = cnpj.length - 2
    numeros = cnpj.substring(0,tamanho);
    digitos = cnpj.substring(tamanho);
    soma = 0;
    pos = tamanho - 7;
    for (i = tamanho; i >= 1; i--) {
      soma += numeros.charAt(tamanho - i) * pos--;
      if (pos < 2)
            pos = 9;
    }
    resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
    if (resultado != digitos.charAt(0))
        return false;
         
    tamanho = tamanho + 1;
    numeros = cnpj.substring(0,tamanho);
    soma = 0;
    pos = tamanho - 7;
    for (i = tamanho; i >= 1; i--) {
      soma += numeros.charAt(tamanho - i) * pos--;
      if (pos < 2)
            pos = 9;
    }
    resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
    if (resultado != digitos.charAt(1))
          return false;
           
    return true;
}

// Os campos com class = obrigatorio, testa se o mesmo foi prenchido. Se o mesmo não foi preenchido,
// a função retorna falso e bloqueia o envio do formulário.
function CampoObrigatorio(campo){
    if (campo.value.length < 1 || campo.value.defaultValue){
        return false;
    } else {
        return true;
    }
}

function campoEmail(campo){
    if (campo.value.indexOff("@") == -1 || campo.value.indexOff(".") == 1){
        return false;
    } else {
        return true;
    }
}

// A função campoNumerico é uma função de validação. Se o campo preenchido apresentar caracters alfanumericos,
// a função retorna falso e bloqueia o envio do formulário.
function campoNumerico(campo){
    if (!/[^\d]/.test(campo.value)){
        return false;
    } else {
        return true;
    }
}

function campoSelecao(campo){
    if (campo.selectIndex > 0){
        return false;
    } else {
        return true;
    }
}

window.onload = function(){
    var formulario = document.getElementById("fCadCliente");
    // console.log(formulario)
    function validaFormulario(formulario){
        for (var i=0; i < qdeCampos; i++){
            var controle = formulario.elements[i];
            console.log(controle);
            if (controle.className.indexOf("obrigatorio") != -1){
                if (!CampoObrigatorio(Controle)){
                    alert("Por favor preencha o campo " + controle.name + ".");
                    return false;
                }
            }

            if (controle.className.indexOf("email") != -1){
                if (!campoEmail(Controle)){
                    alert("Por favor, forneça um endereço de e-mail válido.");
                    return false;
                }
            }

            if (controle.className.indexOf("cpf") != -1){
                if (!campoNumerico(Controle)){
                    alert("O campo " + controle.name + " deve conter somente números.");
                    return false;
                }
            }

            if (controle.className.indexOf("cor") != -1){
                if (!campoSelecao(Controle)){
                    alert("Por favor, selecione um estado.");
                    return false;
                }
            }
        }
    }
    var formulario = document.getElementById("fCadCliente");
    var qdeCampos = formulario.elements.length;
    formulario.onsubmit = function(){
        return validaFormulario(this);
    }
}