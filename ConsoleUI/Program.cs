using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

ProductTest();

//CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach (var item in productManager.GetProductDetail())
    {
        Console.WriteLine($"{item.ProductName,-15} / {item.CategoryName,-15}");
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}