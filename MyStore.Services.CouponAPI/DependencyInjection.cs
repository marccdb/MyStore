using MyStore.Services.CouponAPI.Data.Repository;
using MyStore.Services.CouponAPI.Data.Repository.Interfaces;


namespace MyStore.Services.CouponAPI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCouponService(this IServiceCollection services)
        {
            services.AddScoped<ICouponRepository, CouponRepository>();

            return services;
        }
    }
}
