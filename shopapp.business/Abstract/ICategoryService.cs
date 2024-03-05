using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface ICategoryService : IValidator<Category>
    {
        Task<Category> GetById(int id);

        Task<List<Category>> GetAll();

        Category GetByIdWithProducts(int categoryId);

        void Create(Category entity);
        Task<Category> CreateAysnc(Category entity);

        void Update(Category entity);

        void Delete(Category entity);

        void DeleteFromCategory(int productId, int categoryId);



    }
}
