namespace ClimaTempoSimples.Entidades
{
    public class Cidade
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public virtual Estado Estado { get; set; }
    }
}