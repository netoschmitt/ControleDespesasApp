using System.ComponentModel.DataAnnotations;

namespace ControleDespesasApp.DTOs
{
    public class CriarDespesaDTO
    {
        [Required(ErrorMessage = "Descrição é Obrigatoria.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Valor é Obrigatoria")]
        [Range(0.01,999999, ErrorMessage = "Valor deve ser maior que 0.")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "Data é Obrigatoria")]
        public DateTime Data { get; set; }
    }
}
