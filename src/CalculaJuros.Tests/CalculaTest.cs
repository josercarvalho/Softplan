using CalculaJuros.Api.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CalculaJuros.Tests
{
    [TestClass]
    public class CalculaTest
    {
        [TestMethod]
        public void Verificar_Resultado_RetornaTrue()
        {
            CalculaJurosController _cj = new CalculaJurosController();
            ObjectResult resultado = (ObjectResult)_cj.Get(100, 5).Result;

            var valorPadrao = 105.10;
            var result = Convert.ToDouble(resultado.Value);

            Assert.AreEqual(result, valorPadrao, "Retorno positivo");
        }
    }
}
