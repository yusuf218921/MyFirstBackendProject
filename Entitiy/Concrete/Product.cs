using Core.Entities;


namespace Entities.Concrete
{
    // DB'deki product tablosunu tutmak için oluşturulmuş class
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInstock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
