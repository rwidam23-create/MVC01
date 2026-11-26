namespace MVC01.Models
{
    public class ProductFilter
    {
        public string? Term { get; set; }
        public decimal? MinPrice {  get; set; }
        public int Page {  get; set; }
    }
}
