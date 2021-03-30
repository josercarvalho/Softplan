using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxaDeJuros.Api.Controllers;

namespace TaxaDeJuros.Tests
{
    [TestClass]
    public class TaxaJurosTest
    {
        // [M�todo]_[condi��o]_[resultadoesperado]
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
