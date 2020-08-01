using JurosCompostos.Negocio.Servicos;
using Xunit;

namespace JurosCompostosTestes.Servicos
{
    public static class JurosCompostosCalcularJurosTeste
    {
        [Fact]
        public static void VerificarCalculoJuros()
        {
            var calcularJuros = new JurosCompostosCalcularJuros();

            Assert.Equal("105,10", calcularJuros.CalcularJuros(100, 5, 0.01).ToString());
        }
    }
}
