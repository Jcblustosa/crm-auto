using System;

namespace CRM_Auto.Models
{
    public class AgendamentoServicoModel
    {
        public int IdCliente { get; set; }
        public DateTime DataAgendamento{ get; set; }
        public int IdClienteVeiculo { get; set; }

        public void GerarAgendamento(string cnpj_cpf)
        {

        }
    }
}
