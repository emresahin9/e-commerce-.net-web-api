using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    [SecuredOperation("admin")]
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            var result = BusinessRules.Run(CheckIfBrandNameIsExists(brand.Name));

            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Update(Brand brand)
        {
            var result = BusinessRules.Run(CheckIfBrandNameIsExists(brand.Name));

            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }

        public IResult Delete(int id)
        {
            _brandDal.Delete(x => x.Id == id);
            return new SuccessResult(Messages.BrandDeleted);
        }

        private IResult CheckIfBrandNameIsExists(string brandName)
        {
            if (_brandDal.GetAll(x => x.Name.ToLower() == brandName.ToLower()).Any())
                return new ErrorResult(Messages.BrandNameIsExists);
            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(x => x.Id == brandId));
        }

    }
}
