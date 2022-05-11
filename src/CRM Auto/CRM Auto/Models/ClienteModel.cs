using System;

namespace CRM_Auto.Models
{
    public class ClienteModel
    {
        public string Cnpj_cpf { get; set; }
        public string Nome_cliente { get; set; }
        public char Cnpj_ou_cpf { get; set; }
        public string Apelido { get; set; }
        public DateTime Data_nascimento { get; set; }
        public DateTime Data_cadastro { get; set; }
        public string Id_usuario_cad { get; set; }
        public string Email_nf { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
    }
}
