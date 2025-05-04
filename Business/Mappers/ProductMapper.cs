using Business.Models;
using Data.Entities;

namespace Business.Mappers;

public static class ProductMapper
{
    public static ProductEntity Map(Product product)
    {
        return product != null ? new ProductEntity
        {
            Price = product.Price,
            ProductName = product.ProductName,
        } : null;
    }
    
    public static Product Map(ProductEntity product)
    {
        return product != null ? new Product
        {
            Id = product.Id,
            Price = product.Price,
            ProductName = product.ProductName,
        } : null;
    }

    public static List<Product> Map(List<ProductEntity> products)
    {
        return products != null ? products.Select(Map).ToList() : new List<Product>();
    }

    public static List<ProductEntity> Map(List<Product> products)
    {
        return products != null ? products.Select(Map).ToList() : new List<ProductEntity>();
    }
}