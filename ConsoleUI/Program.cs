using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryProductDal;

ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var item in productManager.GetAll())
{
    Console.Write($"{item.ProductName, -15}");
}
