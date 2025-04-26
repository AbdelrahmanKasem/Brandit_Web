namespace RMSProjectAPI.Model
{
    public class UserResponseDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }

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

        public string Token { get; set; }
        public List<string> Roles { get; set; }
    }
}
