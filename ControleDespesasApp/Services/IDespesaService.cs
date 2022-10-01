using ControleDespesasApp.Models.Despesas;

namespace ControleDespesasApp.Services
{
    public interface IDespesaService
    {
        Task Create(DTOs.CriarDespesaDTO criarDespesaDTO);
        Task<List<Despesa>> FindBy(DateTime dataInicio, DateTime dataFim);
    }
}
