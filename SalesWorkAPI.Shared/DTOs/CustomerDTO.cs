using SalesWorkAPI.Shared.DTOs.Base;

namespace SalesWorkAPI.Shared.DTOs
{
    public class CustomerDTO : BaseEntityDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
