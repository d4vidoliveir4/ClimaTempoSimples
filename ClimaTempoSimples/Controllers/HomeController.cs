using ClimaTempoSimples.Models;
using System.Web.Mvc;

namespace ClimaTempoSimples.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new PrevisaoTempo());
        }

        public ActionResult About()
        {
            ViewBag.Message = "David Matos de Oliveira";

            return View();
        }

        [HttpPost]
        public JsonResult FiltrarCidade(int idCidade)
        {
            var lista = new PrevisaoTempo().ObterPrevisãoProximos7Dias(idCidade);
            var retorno =
            new {
                Titulo1 = lista.Count >= 1? lista[0].DataPrevisao.DayOfWeek.ToString() : string.Empty,
                Clima1 = lista.Count >= 1 ? lista[0].Clima.ToString() : string.Empty,
                Minima1 = lista.Count >= 1? lista[0].TemperaturaMinima.ToString("N0") : string.Empty,
                Maxima1 = lista.Count >= 1 ? lista[0].TemperaturaMaxima.ToString("N0") : string.Empty,

                Titulo2 = lista.Count >= 2 ? lista[1].DataPrevisao.DayOfWeek.ToString() : string.Empty,
                Clima2 = lista.Count >= 2 ? lista[1].Clima.ToString() : string.Empty,
                Minima2 = lista.Count >= 2 ? lista[1].TemperaturaMinima.ToString("N0") : string.Empty,
                Maxima2 = lista.Count >= 2 ? lista[1].TemperaturaMaxima.ToString("N0") : string.Empty,

                Titulo3 = lista.Count >= 3 ? lista[2].DataPrevisao.DayOfWeek.ToString() : string.Empty,
                Clima3 = lista.Count >= 3 ? lista[2].Clima.ToString() : string.Empty,
                Minima3 = lista.Count >= 3 ? lista[2].TemperaturaMinima.ToString("N0") : string.Empty,
                Maxima3 = lista.Count >= 3 ? lista[2].TemperaturaMaxima.ToString("N0") : string.Empty,

                Titulo4 = lista.Count >= 4 ? lista[3].DataPrevisao.DayOfWeek.ToString() : string.Empty,
                Clima4 = lista.Count >= 4 ? lista[3].Clima.ToString() : string.Empty,
                Minima4 = lista.Count >= 4 ? lista[3].TemperaturaMinima.ToString("N0") : string.Empty,
                Maxima4 = lista.Count >= 4 ? lista[3].TemperaturaMaxima.ToString("N0") : string.Empty,

                Titulo5 = lista.Count >= 5 ? lista[4].DataPrevisao.DayOfWeek.ToString() : string.Empty,
                Clima5 = lista.Count >= 5 ? lista[4].Clima.ToString() : string.Empty,
                Minima5 = lista.Count >= 5 ? lista[4].TemperaturaMinima.ToString("N0") : string.Empty,
                Maxima5 = lista.Count >= 5 ? lista[4].TemperaturaMaxima.ToString("N0") : string.Empty,

                Titulo6 = lista.Count >= 6 ? lista[5].DataPrevisao.DayOfWeek.ToString() : string.Empty,
                Clima6 = lista.Count >= 6 ? lista[5].Clima.ToString() : string.Empty,
                Minima6 = lista.Count >= 6 ? lista[5].TemperaturaMinima.ToString("N0") : string.Empty,
                Maxima6 = lista.Count >= 6 ? lista[5].TemperaturaMaxima.ToString("N0") : string.Empty,

                Titulo7 = lista.Count >= 7 ? lista[6].DataPrevisao.DayOfWeek.ToString() : string.Empty,
                Clima7 = lista.Count >= 7 ? lista[6].Clima.ToString() : string.Empty,
                Minima7 = lista.Count >= 7 ? lista[6].TemperaturaMinima.ToString("N0") : string.Empty,
                Maxima7 = lista.Count >= 7 ? lista[6].TemperaturaMaxima.ToString("N0") : string.Empty,
            };
        
            return Json(retorno);
        }

    }
}