using ClimaTempoSimples.Controllers;
using ClimaTempoSimples.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace ClimaTempoSimples.Tests.Controllers
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Model()
        {
            var result = new PrevisaoTempo();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ListaMenoresTemperaturas);
            Assert.IsNotNull(result.ListaMaioresTemperaturas);
            Assert.IsNotNull(result.ListaCidades);
        }

        [TestMethod]
        public void About()
        {
            ViewResult result = new HomeController().About() as ViewResult;
            Assert.AreEqual("David Matos de Oliveira", result.ViewBag.Message);
        }
    }
}
