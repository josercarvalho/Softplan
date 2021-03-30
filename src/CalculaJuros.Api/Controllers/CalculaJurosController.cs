using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculaJuros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        static readonly HttpClient client = new();

        [HttpGet]
        public async Task<IActionResult> Get(double valorinicial, int meses)
        {
            double calculo, valorFinal;
            string txJuros = "";
            string BaseAddress = "http://localhost:5000/";
            string endpoint = "api/TaxaJuros";

            try
            {
                if (valorinicial == 0)
                {
                    return BadRequest("Valor inicial não pode ser nulo!");
                }

                if (meses == 0)
                {
                    return BadRequest("Mês não pode ser nulo!");
                }

                HttpResponseMessage response = await client.GetAsync($"{BaseAddress}{endpoint}");
                if (response.IsSuccessStatusCode)
                {
                    txJuros = await response.Content.ReadAsStringAsync();
                }

                var taxa = Convert.ToDouble(txJuros);

                calculo = 1.00 + (taxa / 100);
                valorFinal = (Math.Pow(calculo, meses)) * valorinicial;
                string resultado = string.Format("{0:N}", valorFinal);

                return Ok(resultado);
            }
            catch (Exception ex)
            {
                string error = $"Erro: {ex.Message}";
                return BadRequest(error);
            }
        }
    }
}
