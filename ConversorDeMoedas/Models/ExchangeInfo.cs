namespace ConversorDeMoedas.Models
{
    public class ExchangeInfo
    {
        public string base_code { get; set; }
        public Dictionary<string, double> rates { get; set; }

    }
}
