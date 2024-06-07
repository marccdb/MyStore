var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.MyStore_Web>("mystore-web");
builder.AddProject<Projects.MyStore_Services_AuthAPI>("auth-api");
builder.AddProject<Projects.MyStore_Services_CouponAPI>("coupon-api");

builder.Build().Run();
