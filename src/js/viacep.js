var app = new Vue({
    el: "#abaRes",
    data: {
      city: "",
      cep: "56302000",
      error: ""
    },
    methods: {
      getCity: function() {
        var self = this;
        console.log(self);
        $.getJSON("https://viacep.com.br/ws/" + this.cep+"/json", function(result) {
          if (("erro" in result)) {
            self.error = "CEP não encontrado";
            self.city = "";
            $(".error").addClass("no");
          } else {
            self.city = result.logradouro +", "+result.bairro+ " - "+ result.localidade + "/" + result.uf;
            
            $(".display").addClass("animated fadeInDown");
          }
          console.log(result);
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
          this.error = "CEP Inválido";
          $(".error").addClass("no");
           $(".display").removeClass("animated fadeInDown");
        }
      }
    }, 
    mounted: function(){
      this.getCity();
    }
  })