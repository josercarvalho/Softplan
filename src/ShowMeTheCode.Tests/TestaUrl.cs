using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShowMeTheCode.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;


namespace ShowMeTheCode.Tests
{
    [TestClass]
    public class TestaUrl
    {
        [TestMethod]
        public void Retornar_Url_ResultadoTrue()
        {
            ShowMeTheCodeController _sm = new ShowMeTheCodeController();

            ObjectResult retorno = (ObjectResult)_sm.Get();

            var resultado = (string)retorno.Value;
            var url = "https://github.com/josercarvalho/Softplan";

            bool result = (resultado == url);

            Assert.IsTrue(result, "Retorno positivo");
        }
    }
}
