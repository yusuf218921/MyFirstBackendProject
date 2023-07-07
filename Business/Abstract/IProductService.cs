using Entities.Concrete;


namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int categoryId);
        List<Product> GetByUnitPrice(decimal min, decimal max);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        Product Get();
    }
}
