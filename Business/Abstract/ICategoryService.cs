﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(int id);
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int categoryId);
        IDataResult<List<CategoryForOption>> GetCategoriesForOptions();
    }
}
