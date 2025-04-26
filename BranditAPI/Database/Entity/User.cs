using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RMSProjectAPI.Database.Entity
{
    public class User: IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly? BirthDate { get; set; }
        public char? Gender { get; set; }
        public string Address { get; set; }
        public DateOnly CreatedAt { get; set; }
        public string? Status { get; set; }
        public string? ImagePath { get; set; }

        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string? CompanyWebsite { get; set; }
        public string SSN { get; set; }
        public bool AcceptTerms { get; set; }
    }
}
