namespace CRM_Auto.Models
{
    public class FuncionarioOficinaModel: FuncionarioModel
    {
        public FuncionarioModel funcionarioModel { get; set; }
        public OficinaModel oficinaModel { get; set; }

    }
}
