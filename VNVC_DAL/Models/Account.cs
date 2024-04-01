using System;
using System.Collections.Generic;

namespace VNVC_DAL.Models;

public partial class Account
{
    public Guid AccountID { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? FullName { get; set; }

    public DateTime? Birthday { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public string? Avatar { get; set; }

    public string? ColorAvatar { get; set; }

    public string? DefaultAvatar { get; set; }

    public DateTime? InsertedDate { get; set; }

    public virtual ICollection<UserLottery> UserLottery { get; set; } = new List<UserLottery>();
}
