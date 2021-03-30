using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxaDeJuros.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TaxaDeJuros.Tests
{
    [TestClass]
    public class taxaJuros
    {
        [TestMethod]
        public void verificarValorTaxa_taxaDeJuros_ResultadoTrue()
        {
            //Arrange
            TaxaJurosController _taxa = new TaxaJurosController();
            decimal valorDaTaxa = (decimal)0.01;
            var valorJuros = 1;

            //Act
            var taxaDeJuros = valorDaTaxa * valorJuros;
            OkObjectResult okResult = (OkObjectResult)_taxa.Get();


            //Assert
            Assert.AreEqual(okResult.Value, taxaDeJuros, "Taxa de Juros ok!");

        }
    }
}
