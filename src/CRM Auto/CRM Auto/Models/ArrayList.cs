using System;
using System.Collections.Generic;

namespace CRM_Auto.Models
{
    internal class ArrayList<T> : List<FuncionarioModel>
    {
    }

    internal class ArrayListOficina<T> : List<OficinaModel>
    {
    }

    internal class ArrayListServico<T> : List<ServicoModel>
    {
    }
    internal class ArrayListCliente<T> : List<ClienteModel>
    {
        public List<ClienteModel> Cliente { get; set; }
    }
}