using ClimaTempoSimples.Enumerados;
using System;

namespace ClimaTempoSimples.Entidades
{
    public class PrevisaoClima
    {
        public int ID { get; set; }
        public EnumClima Clima { get; set; }
        public decimal TemperaturaMinima { get; set; }
        public decimal TemperaturaMaxima { get; set; }
        public DateTime DataPrevisao { get; set; }

        public virtual Cidade Cidade { get; set; }
    }
}