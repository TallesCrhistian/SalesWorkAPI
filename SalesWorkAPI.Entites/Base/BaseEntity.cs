namespace SalesWorkAPI.Entites.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
