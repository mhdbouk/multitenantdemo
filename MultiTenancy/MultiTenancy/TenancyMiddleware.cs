namespace MultiTenancy;

public class TenancyMiddleware
{
    private readonly RequestDelegate _next;
    public TenancyMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, ITenancyManager tenancyManager, ITenantSetter tenant)
    {
        var path = context.Request.Path;
        if (!path.HasValue)
        {
            context.Response.StatusCode = 500;
            return;
        }
        
        // get: client1/todo/1
        var segments = path.Value
                           .Split("/")
                           .Where(x => x != string.Empty)
                           .ToArray();

        if (segments.Length <= 1)
        {
            context.Response.StatusCode = 500;
            await context.Response.WriteAsJsonAsync(new
            {
                status = "TENANT_IS_MISSING",
                message = "Tenant is missing from the request"
            });
            return;
        }

        var tenantName = segments[0];
        var currentTenant = tenancyManager.GetTenant(tenantName);
        if (currentTenant is null)
        {
            context.Response.StatusCode = 500;
            await context.Response.WriteAsJsonAsync(new
            {
                status = "TENANT_IS_NOT_REGISTERED",
                message = $"Tenant {tenantName} is not registered"
            });
            return;
        }

        tenant.Id = currentTenant.Id;
        tenant.Title = currentTenant.Title;

        context.Request.Path = Path.Combine("/", string.Join("/", segments.Skip(1)));
        
        await _next(context);
    }
}






