var app = new Vue({
    el: "#fCadCliente",
    data: {
      city: "",
      cep: "31630009",
      error: ""
    },
    methods: {
      getCity: function() {
        var self = this;
        $.getJSON("https://viacep.com.br/ws/" + this.cep+"/json", function(result) {
            if (("erro" in result)) {
                this.cep.value = "CEP  não encontrado";
                //self.error = "CEP não encontrado";
                //self.city = "";
                //$(".error").addClass("no");
          } else {
                //self.city = result.logradouro +", "+ result.bairro+ " - "+ result.localidade + "/" + result.uf;
                document.getElementById("endereco").value = result.logradouro;
                document.getElementById("bairro").value = result.bairro;
                document.getElementById("cidade").value = result.localidade;
                document.getElementById("estado").value = result.uf;
                //$(".display").addClass("animated fadeInDown");
          }
          // console.log(result);
        });
      }
    },
    watch: {
      cep: function() {
        if (this.cep.length === 8) {
            this.getCity();
            this.error = "";
            $(".error").removeClass("no");
        }
        if (this.cep.length < 8) {
            this.city = "";
            this.cep.value = "CEP Inválido";
            //$(".error").addClass("no");
            //$(".display").removeClass("animated fadeInDown");
        }
      }
    }, 
    mounted: function(){
      this.getCity();
    }
  })