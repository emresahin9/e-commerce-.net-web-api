using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        //public int CityId { get; set; }
        //public City City { get; set; }
        //public int DistrictId { get; set; }
        //public District District { get; set; }
        //public string Address { get; set; }
    }
}
