namespace VNVC_BAL.Models
{
    public class AccountInformationDTO
    {
        public Guid AccountID { get; set; }

        public string? Email { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? FullName { get; set; }

        public DateTime? Birthday { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }

        public DateTime? InsertedDate { get; set; }
    }
}
