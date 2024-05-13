using AutoMapper;
using MyStore.Services.CouponAPI.Models.DTOs;

namespace MyStore.Services.CouponAPI.Models.Configuration
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var configuration = new MapperConfiguration(cfg => {
                cfg.CreateMap<Coupon, CouponDto>();
                cfg.CreateMap<CouponDto, Coupon>();
            });

            return configuration;
        }



    }
}
