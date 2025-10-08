using ConversorDeMoedas.Models;

namespace ConversorDeMoedas.Services
{
    public class ConversorService
    {
    
        public decimal Converter(string fromCurrency, string targetCurrency, decimal value)
        {
            decimal result = value * 3;

            return result;
        }

    }
}
