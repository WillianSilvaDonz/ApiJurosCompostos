namespace JurosCompostos.Negocio.Repositorio
{
    public class TaxaJuros : ITaxaJuros
    {
        public double RetonarTaxaJuros()
        {
            return (1.00 / 100);
        }
    }
}
