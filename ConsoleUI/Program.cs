using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

//ProductTest();

CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
foreach (var category in categoryManager.GetAll())
{
    Console.WriteLine(category.CategoryName);
}

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach (var item in productManager.GetByUnitPrice(20, 5000))
    {
        Console.Write($"{item.UnitPrice,-15}");
    }
}
