using ClimaTempoSimples.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ClimaTempoSimples.ConfiguracoesDb
{
    public class ClimaTempoSimplesContext : DbContext
    {

        public ClimaTempoSimplesContext() : base("ClimaTempoSimplesContext")
        {
        }

        public DbSet<Estado> Estado { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<PrevisaoClima> PrevisaoClima { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}