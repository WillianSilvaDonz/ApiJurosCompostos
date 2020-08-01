using JurosCompostos.Negocio.Repositorio;
using System;

namespace JurosCompostos.Negocio.Servicos
{
    public class JurosCompostosTaxaJuros : IJurosCompostosTaxaJuros
    {
        private readonly ITaxaJuros taxaJuros;

        public JurosCompostosTaxaJuros() : this(new TaxaJuros())
        { }

        public JurosCompostosTaxaJuros(ITaxaJuros taxaJuros)
        {
            this.taxaJuros = taxaJuros;
        }

        public decimal BuscarTaxaJuros()
        {
            return Convert.ToDecimal(taxaJuros.RetonarTaxaJuros());
        }
    }
}
