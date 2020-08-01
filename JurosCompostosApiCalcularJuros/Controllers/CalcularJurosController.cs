using JurosCompostos.Negocio.Servicos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace JurosCompostos.ApiCalcularJuros.Controllers
{
    public class CalcularJurosController : Controller
    {
        [Route("/calculaJuros")]
        [HttpGet]
        public async Task<IActionResult> CalcularJuros(double valorInicial, int meses)
        {
            try
            {
                var calcularJuros = new JurosCompostosCalcularJuros();
                var taxaJuros = await calcularJuros.BuscarTaxaJuros();
                return Json( calcularJuros.CalcularJuros(valorInicial, meses, taxaJuros) );
            }
            catch(Exception ex)
            {
                throw new Exception($"Erro Api {ex.Message}");
            }
        }
    }
}
