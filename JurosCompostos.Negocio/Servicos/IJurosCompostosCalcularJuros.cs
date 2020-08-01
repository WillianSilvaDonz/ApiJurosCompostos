using System.Threading.Tasks;

namespace JurosCompostos.Negocio.Servicos
{
    public interface IJurosCompostosCalcularJuros
    {
        decimal CalcularJuros(double valorInicial, int meses, double taxaJuros);

        Task<double> BuscarTaxaJuros();
    }
}
