namespace MultiTenancy;

public interface ITenancyManager
{
    Tenant? GetTenant(string tenantName);
}
public class TenancyManager : ITenancyManager
{
    public Tenant? GetTenant(string tenantName)
        => tenantName switch
        {
            "client1" => new Tenant() { Id = 1, Title = "Client1" },
            "client2" => new Tenant() { Id = 2, Title = "Client2" },
            "client3" => new Tenant() { Id = 3, Title = "Client3" },
            _ => null
        };
}

public class Tenant : ITenant, ITenantSetter
{
    public int Id { get; set; }
    public required string Title { get; set; }
}

public interface ITenant
{
    int Id { get; }
    string Title { get; }
}

public interface ITenantSetter
{
    int Id { set; }
    string Title { set; }
}
