namespace three_pmetrics.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string SourceName { get; set; } = string.Empty;
        public string? SourceIcon { get; set; } = string.Empty;
    }
}