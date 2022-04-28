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
        /* console.log("Primeiro if el:" + el)
        console.log("Primeiro if nomeElemento: " + nomeElemento)
        console.log("Primeiro if: " + document.getElementById("abaRes").style.display) */
        if (document.getElementById("abaRes").style.display == "none" || document.getElementById("abaRes").style.display == " "){
            document.getElementById("abaVeiculo").style.display = 'none'
            document.getElementById("abaRes").style.display = 'block'}
        else if(displayAba == "block"){
            document.getElementById("abaVeiculo").style.display = 'none'
        }
    }

    if(nomeElemento == "abaVeiculo"){
        /* console.log("Segundo if el:" + el)
        console.log("Segundo if nomeElemento: " + nomeElemento)
        console.log("Primeiro if: " + document.getElementById("abaVeiculo").style.display) */
        if(document.getElementById("abaVeiculo").style.display == "none"){
            document.getElementById("abaRes").style.display = 'none'
            document.getElementById("abaVeiculo").style.display = 'block'}
        else if(displayAba == "block"){
            document.getElementById("abaRes").style.display = 'none'
        }
    }
};