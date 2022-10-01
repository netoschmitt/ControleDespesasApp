using ControleDespesasApp.Models.Despesas;

namespace ControleDespesasApp.DTOs
{
    public class ListDespesaDTO
    {
        public ListDespesaDTO()
        {
            DataInicio = DateTime.UtcNow.AddDays(-7);
            DataFim = DateTime.UtcNow.AddDays(3);
            Items = new List<Despesa>(); // previne q a list fique null
        }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public List<Despesa> Items { get; set; }
    }
}
