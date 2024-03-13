using System.Data;
using Dapper;
using eShop.ApplicationCore.Models;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrustructure.Data;

namespace eShop.Infrustructure.Repository;

public class OrderDetailRepository: IOrderDetailRepository
{
    private readonly eShopDbContext eShopDbContext;

    public OrderDetailRepository(eShopDbContext context)
    {
        eShopDbContext = context;
    }
    public int Insert(OrderDetail entity)
    {
        throw new NotImplementedException();
    }

    public int Update(OrderDetail entity)
    {
        var conn = eShopDbContext.GetDbConnection();
        return conn.Execute("sp_InsertProduct",
            new
            {
                OrderId = entity.OrderId, price = entity.price, ProductId = entity.ProductId, quantity = entity.quantity
            }, commandType: CommandType.StoredProcedure);
       
    }

    public int Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<OrderDetail> GetAll()
    {
        var conn = eShopDbContext.GetDbConnection();
        return conn.Query<OrderDetail, Product, OrderDetail>("sp_orderdetails", (o, p) =>
        {
            o.Product = p;
            return o;
        });
    }

    public OrderDetail GetById(int id)
    {
        throw new NotImplementedException();
    }
}