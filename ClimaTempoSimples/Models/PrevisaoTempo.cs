using ClimaTempoSimples.ConfiguracoesDb;
using ClimaTempoSimples.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClimaTempoSimples.Models
{
    public class PrevisaoTempo
    {
        private ClimaTempoSimplesContext db = new ClimaTempoSimplesContext();

        public List<PrevisaoClima> ListaMaioresTemperaturas { get;set; }
        public List<PrevisaoClima> ListaMenoresTemperaturas { get;set; }
        public List<Cidade> ListaCidades { get;set; }
        public int IdCidade { get; set; }

        public PrevisaoTempo()
        {
            ListaCidades = db.Cidade.ToList();
            ListaMaioresTemperaturas = db.PrevisaoClima.ToList().Where(w=>w.DataPrevisao.Date == DateTime.Today.Date).OrderBy(o=>o.TemperaturaMaxima).Take(3).ToList();
            ListaMenoresTemperaturas = db.PrevisaoClima.ToList().Where(w=>w.DataPrevisao.Date == DateTime.Today.Date).OrderByDescending(o=>o.TemperaturaMinima).Take(3).ToList();
            IdCidade = ListaCidades.FirstOrDefault()?.ID ?? 0;
        }

        public List<PrevisaoClima> ObterPrevisãoProximos7Dias(int idCidade)
        {
            var lista = db.PrevisaoClima.ToList().Where(w=>w.Cidade.ID == idCidade && w.DataPrevisao.Date >= DateTime.Today.Date && w.DataPrevisao.Date <= DateTime.Today.Date.AddDays(7)).ToList();
            return lista;
        }

    }
}