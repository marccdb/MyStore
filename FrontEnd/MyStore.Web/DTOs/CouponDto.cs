namespace MyStore.Web;

public class CouponDto
{
    public string? CouponCode { get; set; }
    public double DiscountAmount { get; set; }
    public int MinAmount { get; set; }
}
