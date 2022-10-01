using ControleDespesasApp.Models.Despesas;
using Microsoft.EntityFrameworkCore;

namespace ControleDespesasApp.Infra.Database
{
    public class ControleDespesasContext : DbContext
    {
        public DbSet<Despesa> Despesas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlite("Data Source=ControleDespesa.db");
    }
}
