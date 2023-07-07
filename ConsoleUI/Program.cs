using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryProductDal;

ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var item in productManager.GetByUnitPrice(20,5000))
{
    Console.Write($"{item.UnitPrice, -15}");
}
