﻿namespace VNVC_Client.Models
{
    public class AccountRequest
    {
        public string? Email { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? FullName { get; set; }

        public DateTime? Birthday { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }
    }
}
