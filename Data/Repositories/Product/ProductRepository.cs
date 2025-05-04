using Data.Context;
using Data.Entities;
using Data.Repositories.Base;

namespace Data.Repositories.Product;

public class ProductRepository(DataContext ctx)
    : BaseRepository<ProductEntity>(ctx), IProductRepository
{ }
