using Business.Concrete;
using DataAccess.Concrete.InMemoryProductDal;

ProductManager productManager = new ProductManager(new InMemoryProductDal());
foreach (var item in productManager.GetAll())
{
    Console.Write($"{item.ProductName, -15}");
}
