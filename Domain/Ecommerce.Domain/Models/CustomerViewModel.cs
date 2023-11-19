using Ecommerce.Domain.Entities;

namespace Ecommerce.Domain.Models
{
    public class CustomerViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string IdentityNumber { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
        public Payment Payment { get; set; }
    }
}
