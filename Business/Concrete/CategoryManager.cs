﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            // iş kodları
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            // iş kodları
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
