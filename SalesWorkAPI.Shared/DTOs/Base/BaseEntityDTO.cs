namespace SalesWorkAPI.Shared.DTOs.Base
{
    public class BaseEntityDTO
    {
        public Guid Id { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
