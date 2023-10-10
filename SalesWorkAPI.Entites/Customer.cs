using SalesWorkAPI.Entites.Base;

namespace SalesWorkAPI.Entites
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
