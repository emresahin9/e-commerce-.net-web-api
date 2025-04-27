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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        [ValidationAspect(typeof(CategoryValidator))]
        public IResult Add(Category category)
        {
            var result = BusinessRules.Run(CheckIfCategoryNameIsExists(category.Name));

            _categoryDal.Add(category);
            return new SuccessResult(Messages.CategoryAdded);
        }

        [ValidationAspect(typeof(CategoryValidator))]
        public IResult Update(Category category)
        {
            var result = BusinessRules.Run(CheckIfCategoryNameIsExists(category.Name));

            _categoryDal.Update(category);
            return new SuccessResult(Messages.CategoryUpdated);
        }

        public IResult Delete(int id)
        {
            _categoryDal.Delete(x => x.Id == id);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        private IResult CheckIfCategoryNameIsExists(string categoryName)
        {
            if (_categoryDal.GetAll(x => x.Name.ToLower() == categoryName.ToLower()).Any())
                return new ErrorResult(Messages.CategoryNameIsExists);
            return new SuccessResult();
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(x => x.Id == categoryId));
        }

        public IDataResult<List<CategoryForOption>> GetCategoriesForOptions()
        {
            return new SuccessDataResult<List<CategoryForOption>>(_categoryDal.GetCategoriesForOptions());
        }
    }
}
