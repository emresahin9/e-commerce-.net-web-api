using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetAllProductsDetails(int? categoryId);
        ProductDetailDto GetProductDetailById(int productId);
    }
}
