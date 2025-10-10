using ConversorDeMoedas.Models;
using System.Text.Json;
using System.Threading.Tasks;
using ConversorDeMoedas.Controllers;

namespace ConversorDeMoedas.Services
{
    public class ConversorService
    {
        HttpClient client = new HttpClient();

        public async Task<decimal> Converter(string fromCurrency, string targetCurrency, decimal value)
        {

            string url = $"https://open.er-api.com/v6/latest/{fromCurrency}";
            string answer = await client.GetStringAsync(url);
            ExchangeInfo exchangeInfo = JsonSerializer.Deserialize<ExchangeInfo>(answer);

            decimal result = value * (decimal) exchangeInfo.rates[targetCurrency];

            return result;
        }

    }
}
