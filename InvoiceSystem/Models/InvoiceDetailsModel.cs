using System.ComponentModel.DataAnnotations;

namespace InvoiceSystem.Models
{
    public class InvoiceDetailsModel
    {
        public string Discription { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Qty { get; set; }
        [Required]
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public string? InvoiceNote { get; set; }
        public string? Attachement { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxTotal { get; set; }
        public decimal GrandTotal { get; set; }
        public InvoiceInfoModel InvoiceInfo { get; set; }
        public ProductModel Product { get; set; }
    }
}
