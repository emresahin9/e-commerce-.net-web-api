using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(int id);
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetById(int productId);
        IDataResult<List<ProductDetailDto>> GetAllProductsDetails(int? categoryId);
        IDataResult<ProductDetailDto> GetProductDetailById(int productId);
    }
}
