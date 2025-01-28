namespace beautysalon.Database.Models
{
    public class ApplicationUser
    {
        public Guid CompanyId { get; set; }
        public required Company Company { get; set; }
        public string? FirstName { get; set; } 
        public string? LastName { get; set; } 
        public string? Street { get; set; } 
        public string? City { get; set; } 
        public string? State { get; set; }
        public string? PostalCode { get; set; } 
        public string? Country { get; set; }
    }
}
