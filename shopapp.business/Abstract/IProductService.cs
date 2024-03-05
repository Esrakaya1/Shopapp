using System.Collections.Generic;
using System.Threading.Tasks;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface IProductService : IValidator<Product>
    {
        Task<Product> GetById(int id);

        Product GetByIdWithCategories(int id);
        Product GetProductDetails(string url);
        List<Product> GetProductsByCategory(string name, int page, int pageSize);

        Task<List<Product>> GetAll();
        List<Product> GetHomePageProducts();
        List<Product> GetSearchResult(string searchString);

        bool Create(Product entity);
        Task<Product> CreateAysnc(Product entity);

        bool Update(Product entity, int[] categoryIds);

        void Delete(Product entity);

        Task DeleteAsync(Product entity);
        int GetCountByCategory(string category);

        Task UpdateAsync(Product entityToUpdate, Product entity);
    }
}
