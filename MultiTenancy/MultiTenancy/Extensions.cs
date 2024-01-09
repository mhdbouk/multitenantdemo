namespace MultiTenancy;

public static class Extensions
{
    public static IServiceCollection AddMultiTenancy(this IServiceCollection services)
    {
        services.AddScoped<ITenancyManager, TenancyManager>();
        services.AddScoped<Tenant>();
        services.AddScoped<ITenant>(s => s.GetRequiredService<Tenant>());
        services.AddScoped<ITenantSetter>(s => s.GetRequiredService<Tenant>());
        
        return services;
    }
}
