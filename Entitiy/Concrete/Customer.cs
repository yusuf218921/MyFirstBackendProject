using Core.Entities;


namespace Entities.Concrete
{
    // DB'deki Customer tablosunu tutmak için oluşturulmuş class
    public class Customer : IEntity
    {
        public string CustomerId { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
    }
}
