using JurosCompostos.Entidades.CalcularJuros;
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
        public async Task<ActionResult<decimal>> CalcularJuros(double valorInicial, int meses)
        {
            try
            {
                var calcularJuros = new JurosCompostosCalcularJuros();
                var taxaJuros = await calcularJuros.BuscarTaxaJuros();
                return calcularJuros.CalcularJuros(valorInicial, meses, taxaJuros);
            }
            catch(Exception ex)
            {
                throw new Exception($"Erro Api {ex.Message}");
            }
        }

        [Route("/showmethecode")]
        [HttpGet]
        public async Task<ActionResult<RetornoInfo>> MostrarInfoProjeto()
        {
            try
            {
                var retorno = new RetornoInfo()
                {
                    Nome = "Willian Maikon da Silva",
                    Titulo = "Api Juros Compostos",
                    LinkGit = "https://github.com/WillianSilvaDonz/ApiJurosCompostos"
                };
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro Api {ex.Message}");
            }
        }
    }
}
