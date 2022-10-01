using System.ComponentModel.DataAnnotations;

namespace ControleDespesasApp.Models.Despesas
{
    public class Despesa
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
