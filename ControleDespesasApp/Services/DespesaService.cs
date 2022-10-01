using ControleDespesasApp.Infra.Database;
using ControleDespesasApp.Models.Despesas;
using Microsoft.EntityFrameworkCore;

namespace ControleDespesasApp.Services
{
    public class DespesaService : IDespesaService
    {
        private readonly ControleDespesasContext _dbContext;

        public DespesaService(ControleDespesasContext dbContext)
        {
            _dbContext = dbContext;
        }

        // criar despesa metodo
        public async Task Create(DTOs.CriarDespesaDTO criarDespesaDTO)
        {
            await _dbContext.Despesas.AddAsync(new Despesa()
            {
                Descricao = criarDespesaDTO.Descricao,
                Data = criarDespesaDTO.Data,
                Valor = criarDespesaDTO.Valor,
            });

            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Despesa>> FindBy(DateTime datainicio, DateTime dataFim)
        {
            if (datainicio > dataFim)
                throw new Exception("Data final deve ser maior que data inicial.");
            
            var items = await _dbContext.Despesas.Where(d => d.Data >= datainicio &&  d.Data <= dataFim).AsNoTracking()
                .ToListAsync();

            return items;
        }
    }
}
