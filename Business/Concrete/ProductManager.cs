using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;


namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            // İş Kodları
            // Yetkisi var mı ?
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            // İş Kodları
            // Yetkisi var mı ?
            _productDal.Delete(product);
        }

        public Product Get()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            // İş Kodları
            // Yetkisi var mı ?
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=> p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public void Update(Product product)
        {
            // İş Kodları
            // Yetkisi var mı ?
            _productDal.Update(product);
        }
    }
}
