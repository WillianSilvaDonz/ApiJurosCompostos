using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace JurosCompostos.Negocio.Servicos
{
    public class JurosCompostosCalcularJuros : IJurosCompostosCalcularJuros
    {
        #region Propriedades Privada
        private readonly HttpClient _httpClient;
        private readonly string _urlApi;
        #endregion

        #region Construtor
        public JurosCompostosCalcularJuros()
        {
            _httpClient = new HttpClient();
            _urlApi = "https://jurospadraowillian.azurewebsites.net/";
            configuracaoClienteHttp();
        }
        #endregion

        #region Metodos Privados
        private void configuracaoClienteHttp()
        {
            _httpClient.BaseAddress = new Uri(_urlApi);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        #endregion

        #region Metodos Publicos
        public async Task<double> BuscarTaxaJuros()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("taxaJuros");
            if (response.IsSuccessStatusCode)
            {
                string retornoTaxaJuros = await response.Content.ReadAsStringAsync();
                return Convert.ToDouble(retornoTaxaJuros);
            }
            else
            {
                throw new Exception("Por favor configurar a url da taxa de juros");
            }
        }

        public decimal CalcularJuros(double valorInicial, int meses, double taxaJuros)
        {
            double pagamento = (valorInicial * Math.Pow((taxaJuros + 1), (meses)));

            pagamento *= 100;
            pagamento = Math.Truncate(pagamento);
            pagamento /= 100;
                
            return Convert.ToDecimal(pagamento.ToString("N2"));
        }
        #endregion
    }
}
