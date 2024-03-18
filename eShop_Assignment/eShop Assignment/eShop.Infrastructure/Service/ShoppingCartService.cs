using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.ApplicationCore.ServiceInterface;
using eShop.Infrastructure.Data;
using eShop.Infrastructure.Repository;

namespace eShop.Infrastructure.Service;

public class ShoppingCartService: IShoppingCartService
{
    private readonly IShoppingCartRepository _shoppingCartRepository;
    private readonly ICartItemRepository _cartItemRepository;
    private readonly IProductRepository _productRepository;
    public ShoppingCartService(IShoppingCartRepository repo, ICartItemRepository crepo,
        IProductRepository prepo)
    {
        _shoppingCartRepository = repo;
        _cartItemRepository = crepo;
        _productRepository = prepo;
    }
    
    public IEnumerable<Product> GetAllProducts(int id)
    {
        var shoppingCart = _shoppingCartRepository.GetByCustomerId(id).Id;
        var result = _cartItemRepository.GetbyShoppingCartId(shoppingCart);
        List<Product> list = new List<Product>();
        foreach (var item in result)
        {
            list.Add(_productRepository.GetById(item.ProductId));
        }
        return list as IEnumerable<Product>;
    }

    public decimal GetTotal(int id)
    {
        var shoppingCart = _shoppingCartRepository.GetByCustomerId(id).Id;
        var result = _cartItemRepository.GetbyShoppingCartId(shoppingCart);
        List<Product> list = new List<Product>();
        foreach (var item in result)
        {
            list.Add(_productRepository.GetById(item.ProductId));
        }

        decimal num = 0;
        foreach (var item in list)
        {
            num += item.Price;
        }

        return num;
    }

    public void AddToCart(int uid, int productId)
    {
        // Retrieve the user's shopping cart
        var shoppingCart = _shoppingCartRepository.GetByCustomerId(uid);

        // Retrieve the cart item for the given product and shopping cart
        var cartItem = _cartItemRepository.GetByProductId(shoppingCart.Id, productId);

        if (cartItem == null)
        {
            // If the cart item doesn't exist, create a new one
            cartItem = new CartItem
            {
                ProductId = productId,
                ShoppingCartId = shoppingCart.Id,
                Quantity = 1 // Set initial quantity to 1
            };
            _cartItemRepository.Insert(cartItem);
        }
        else
        {
            // If the cart item exists, increment its quantity
            cartItem.Quantity++; // Increment the quantity
            _cartItemRepository.Update(cartItem);
        }
    }
}