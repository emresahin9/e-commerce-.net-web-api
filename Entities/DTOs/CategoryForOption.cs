using Core.Entities.Abstract;

namespace Entities.DTOs
{
    public class CategoryForOption : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
