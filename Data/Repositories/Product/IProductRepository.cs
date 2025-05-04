using Data.Entities;
using Data.Repositories.Base;

namespace Data.Repositories.Product;

public interface IProductRepository : IBaseRepository<ProductEntity>
{ }