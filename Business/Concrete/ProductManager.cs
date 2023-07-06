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

        public List<Product> GetAll()
        {
            // İş Kodları
            // Yetkisi var mı ?
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            // İş Kodları
            // Yetkisi var mı ?
            return _productDal.GetAllByCategory(categoryId);
        }

        public void Update(Product product)
        {
            // İş Kodları
            // Yetkisi var mı ?
            _productDal.Update(product);
        }
    }
}
