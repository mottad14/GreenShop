using System;
using GreenShop.Shared;

namespace GreenShop.Client.Services.ProductService
{
    public interface IProductService
    {
        // In this Service Space, we have architectured a place for our Products to be stored from Db
        // ProductList and other Components will access our Products from the class/interface
        // Now, we don't have to make calls from each component
        // and only access the services and products are stored in one place
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        Task GetProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProduct(int productId);

    }
}

