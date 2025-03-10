using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class City : IEntity
    {
        public City()
        {
            Districts = new List<District>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<District> Districts { get; set; }
    }
}
