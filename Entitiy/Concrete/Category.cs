using Core.Entities;

namespace Entities.Concrete
{
    // DB'deki Category tablosunu tutmak için oluşturulmuş class
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
