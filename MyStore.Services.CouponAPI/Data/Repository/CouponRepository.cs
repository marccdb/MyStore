using Microsoft.EntityFrameworkCore;
using MyStore.Services.CouponAPI.Data.Repository.Interfaces;
using MyStore.Services.CouponAPI.Models;

namespace MyStore.Services.CouponAPI.Data.Repository
{
    public class CouponRepository(AppDbContext appDbContext) : ICouponRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task DeleteCouponById(int couponId)
        {
            var couponToRemove = await _appDbContext.Coupons.FirstOrDefaultAsync(x => x.CouponId == couponId);
            if (couponToRemove != null)
            {
                _appDbContext.Coupons.Remove(couponToRemove);
                await _appDbContext.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Coupon was not found!");
            }
        }

        public async Task<Coupon> GetACouponById(int couponId)
        {
            var retrievedCoupon = await _appDbContext.Coupons.AsNoTracking().FirstOrDefaultAsync(x => x.CouponId == couponId);
            if (retrievedCoupon != null)
            {
                return retrievedCoupon;
            }
            else
            {
                throw new KeyNotFoundException("Coupon was not found!");
            }
        }

        public async Task<IEnumerable<Coupon>> GetListOfCoupons()
        {
            var listOfCoupons = await _appDbContext.Coupons.AsNoTracking().ToListAsync();
            if (listOfCoupons != null)
            {
                return listOfCoupons;
            }
            else
            {
                throw new KeyNotFoundException("Coupons were not found!");
            }
        }

        public async Task UpdateCoupon(int couponId, Coupon updatedCoupon)
        {
            var couponToUpdate = await _appDbContext.Coupons.FirstOrDefaultAsync(x => x.CouponId == couponId);
            if (couponToUpdate != null)
            {
                _appDbContext.Entry(couponToUpdate).CurrentValues.SetValues(updatedCoupon);
                await _appDbContext.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Coupon was not found!");
            }

        }

        public async Task CreateNewCoupon(Coupon newCoupon)
        {
            if (newCoupon != null)
            {
                await _appDbContext.Coupons.AddAsync(newCoupon);
                await _appDbContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidDataException("Please provide a valid coupon");
            }
        }


    }
}
