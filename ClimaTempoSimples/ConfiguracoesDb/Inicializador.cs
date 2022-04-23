using ClimaTempoSimples.Entidades;
using ClimaTempoSimples.Enumerados;
using System;
using System.Collections.Generic;

namespace ClimaTempoSimples.ConfiguracoesDb
{
    public class Inicializador : System.Data.Entity.DropCreateDatabaseIfModelChanges<ClimaTempoSimplesContext>
    {
        protected override void Seed(ClimaTempoSimplesContext context)
        {
            var courses = new List<PrevisaoClima>
            {
                new PrevisaoClima { Cidade = new Cidade { Nome = "São paulo", Estado = new Estado { Nome = "São Paulo", UF = "SP"}}, TemperaturaMaxima = 30, TemperaturaMinima = 20, Clima = EnumClima.Ensolarado, DataPrevisao = DateTime.Now },
                new PrevisaoClima { Cidade = new Cidade { Nome = "Teresina", Estado = new Estado { Nome = "Piauí", UF = "PI"}}, TemperaturaMaxima = 40, TemperaturaMinima = 30, Clima = EnumClima.Ensolarado, DataPrevisao = DateTime.Now },
                new PrevisaoClima { Cidade = new Cidade { Nome = "Rio de Janeiro", Estado = new Estado { Nome = "Rio de Janeiro", UF = "RJ"}}, TemperaturaMaxima = 40, TemperaturaMinima = 30, Clima = EnumClima.Chuvoso, DataPrevisao = DateTime.Now }
            };
            courses.ForEach(s => context.PrevisaoClima.Add(s));
            context.SaveChanges();

        }
    }
}