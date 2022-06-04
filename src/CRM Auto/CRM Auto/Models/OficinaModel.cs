using CRM_Auto.Util;
using System.Collections.Generic;
using System.Data;

namespace CRM_Auto.Models

{
    public class OficinaModel
    {
        public int Id_oficina { get; set; }
        public string Cnpj { get; set; }
        public string Nome_oficina { get; set; }
        public string Apelido { get; set; }
        public string Insc_estadual { get; set; }
        public string Insc_municipal { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public string Email_Nf { get; set; }
        public string Opcao_cadastro { get; set; }

        public OficinaModel(int Id_oficina, string Cnpj, string Nome_oficina, string Apelido, 
                            string Insc_estadual, string Insc_municipal, string Cep, string Logradouro,
                            string Numero, string Complemento, string Bairro, string Cidade, string Telefone1,
                            string Telefone2, string Email, string Email_Nf, string Opcao_cadastro)

        {
            this.Id_oficina = Id_oficina;
            this.Cnpj = Cnpj;
            this.Nome_oficina = Nome_oficina;
            this.Apelido = Apelido;
            this.Insc_estadual = Insc_estadual;
            this.Insc_municipal = Insc_municipal;
            this.Cep = Cep;
            this.Logradouro = Logradouro;
            this.Numero = Numero;
            this.Complemento = Complemento;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.Telefone1 = Telefone1;
            this.Telefone2 = Telefone2;
            this.Email = Email;
            this.Email_Nf = Email_Nf;
            this.Opcao_cadastro = Opcao_cadastro;
        }

        public OficinaModel()
        {

        }

        public List<OficinaModel> BuscarOficinas()
        {
            ArrayListOficina<OficinaModel> oficinas = new ArrayListOficina<OficinaModel>();

            string command = $"SELECT * FROM OFICINA ORDER BY NOME_OFICINA";

            //DAL dal = new DAL();
            //DataTable dt = dal.GetData(command);

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                OficinaModel oficina = new OficinaModel (int.Parse(dt.Rows[i]["Id_oficina"].ToString()),
                    dt.Rows[i]["Cnpj"].ToString(),
                    dt.Rows[i]["Nome_oficina"].ToString(),
                    dt.Rows[i]["Apelido"].ToString(),
                    dt.Rows[i]["Insc_estadual"].ToString(),
                    dt.Rows[i]["Insc_municipal"].ToString(),
                    dt.Rows[i]["Cep"].ToString(),
                    dt.Rows[i]["Logradouro"].ToString(),
                    dt.Rows[i]["Numero"].ToString(),
                    dt.Rows[i]["Complemento"].ToString(),
                    dt.Rows[i]["Bairro"].ToString(),
                    dt.Rows[i]["Cidade"].ToString(),
                    dt.Rows[i]["Telefone1"].ToString(),
                    dt.Rows[i]["Telefone2"].ToString(),
                    dt.Rows[i]["Email"].ToString(),
                    dt.Rows[i]["Email_Nf"].ToString(),
                    dt.Rows[i]["Opcao_cadastro"].ToString());

                oficinas.Add(oficina);
            }
            return oficinas;
        }
    }
}
