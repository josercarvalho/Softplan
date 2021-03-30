using Microsoft.AspNetCore.Mvc;
using System;

namespace TaxaDeJuros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        [HttpGet]
        //public IActionResult Get(int? taxa)
        public IActionResult Get()
        {
            decimal txJuros = (decimal)1; // (decimal)(taxa != null ? taxa : 1);
            decimal vlJuros = txJuros / 100;
            decimal result = txJuros * vlJuros;

            try
            {
                return Ok(value: result);
            }
            catch (Exception ex)
            {
                string error = $"Erro: {ex.Message}";
                return base.BadRequest(error);
            }
        }
    }
}
