namespace MyStore.Services.CouponAPI.Models.DTOs
{
    public class CouponDto
    {
        public string? CouponCode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
