using ClimaTempoSimples.ConfiguracoesDb;
using System.Data.Entity.Migrations;

namespace ClimaTempoSimples.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ClimaTempoSimplesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ClimaTempoSimplesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
