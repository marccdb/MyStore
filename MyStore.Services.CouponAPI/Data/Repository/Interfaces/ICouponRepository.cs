using MyStore.Services.CouponAPI.Models;

namespace MyStore.Services.CouponAPI.Data.Repository.Interfaces
{
    public interface ICouponRepository
    {
        Task<IEnumerable<Coupon>> GetListOfCoupons();
        Task<Coupon> GetACouponById(int couponId);
        Task UpdateCoupon(int couponId, Coupon updatedCoupon);
        Task DeleteCouponById(int couponId);
        Task CreateNewCoupon(Coupon newCoupon);
    }
}
