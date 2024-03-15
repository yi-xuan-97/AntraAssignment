using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace eShop.Infrustructure.Data;

public class eShopDbContext
{
    private readonly IConfiguration configuration;
    private readonly string connectionString;

    public eShopDbContext(IConfiguration _configuration)
    {
        configuration = _configuration;
        connectionString = configuration.GetConnectionString("eShopDbConnection");
    }

    public IDbConnection GetDbConnection()
    {
        return new SqlConnection(connectionString);
    }
}