using JurosCompostos.Negocio.Repositorio;
using JurosCompostos.Negocio.Servicos;
using Moq;
using Xunit;

namespace JurosCompostosTestes.Servicos
{
    public class JurosCompostosTaxaJurosTeste
    {
        [Fact]
        public void BuscarTaxaJuros()
        {
            var taxaJuros = new JurosCompostosTaxaJuros();

            Assert.Equal("0,01", taxaJuros.BuscarTaxaJuros().ToString());
        }
        
        [Fact]
        public void BuscarTaxaJurosMock()
        {
            var moqTaxaJuros = new Mock<ITaxaJuros>();

            moqTaxaJuros.Setup(x => x.RetonarTaxaJuros()).Returns(0.05);

            var taxaJuros = new JurosCompostosTaxaJuros(moqTaxaJuros.Object);

            Assert.Equal("0,05", taxaJuros.BuscarTaxaJuros().ToString());
        }
    }
}
