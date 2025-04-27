using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class ProductImage : IEntity
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public int ProductId { get; set; }
    }
}
