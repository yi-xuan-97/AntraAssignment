using System.Data;
using eShop.ApplicationCore.Models;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrustructure.Data;
using Dapper;

namespace eShop.Infrustructure.Repository;

public class ProductRepository : IProductRepsitory
{
    private readonly eShopDbContext eShopDbContext;

    public ProductRepository(eShopDbContext context)
    {
        eShopDbContext = context;
    }
    
    public int Insert(Product entity)
    {
        var conn = eShopDbContext.GetDbConnection();
        // return conn.Execute("Insert into Product values (@name,@price,@description,@category_id)", entity);
        return conn.Execute("INSERT INTO Product (name, price, description, category_id) VALUES (@name, @price, @description, @category_id)", entity);
    }

    public int Update(Product entity)
    {
        var conn = eShopDbContext.GetDbConnection(); 
        return conn.Execute("Update Product set name=@name, price=@price, description=@description, category_id=@category_id where id=@Id", entity);
    }

    public int Delete(int id)
    {
        var conn = eShopDbContext.GetDbConnection();
        return conn.Execute("Delete from Product where id=@id", id);
    }

    public IEnumerable<Product> GetAll()
    {
        var conn = eShopDbContext.GetDbConnection();
        return conn.Query<Product>("Select Id, name, price, description, category_id from Product");
    }

    public Product GetById(int id)
    {
        var conn = eShopDbContext.GetDbConnection();
        return conn.QueryFirstOrDefault<Product>("Select Id, name, price, description, category_id from Product where id=@id", id);
    }
}