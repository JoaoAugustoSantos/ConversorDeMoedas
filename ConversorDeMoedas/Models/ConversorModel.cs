namespace ConversorDeMoedas.Models
{
    public class ConversorModel
    {
        public string FromCurrency { get; set; }
        public string TargetCurrency {  get; set; }
        public decimal Value { get; set; }
        public decimal? Result {  get; set; } = null;

    }
}
