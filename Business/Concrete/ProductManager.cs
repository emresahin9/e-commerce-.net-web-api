using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    [SecuredOperation("admin")]
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            var result = BusinessRules.Run(CheckIfProductNameIsExists(product.Name));

            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Update(Product product)
        {
            var result = BusinessRules.Run(CheckIfProductNameIsExists(product.Name));

            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public IResult Delete(int id)
        {
            _productDal.Delete(x => x.Id == id);
            return new SuccessResult(Messages.ProductDeleted);
        }

        private IResult CheckIfProductNameIsExists(string productName)
        {
            if (_productDal.GetAll(x => x.Name.ToLower() == productName.ToLower()).Any())
                return new ErrorResult(Messages.ProductNameIsExists);
            return new SuccessResult();
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll());
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(x => x.Id == productId));
        }

        public IDataResult<List<ProductDetailDto>> GetAllProductsDetails(int? categoryId)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetAllProductsDetails(categoryId));
        }

        public IDataResult<ProductDetailDto> GetProductDetailById(int productId)
        {
            return new SuccessDataResult<ProductDetailDto>(_productDal.GetProductDetailById(productId));
        }
    }
}
