using JurosCompostos.Negocio.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace JurosCompostos.ApiJurosPadrao.Controllers
{
    public class JurosPadraoController : Controller
    {
        [Route("/taxaJuros")]
        [HttpGet]
        public decimal Get()
        {
            var taxaJuros = new JurosCompostosTaxaJuros();
            return taxaJuros.BuscarTaxaJuros();
        }
    }
}
