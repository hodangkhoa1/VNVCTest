using System;
using System.Collections.Generic;

namespace VNVC_DAL.Models;

public partial class UserLottery
{
    public Guid UserLotteryID { get; set; }

    public Guid? AccountID { get; set; }

    public DateTime? Slot { get; set; }

    public int? Result { get; set; }

    public DateTime? InsertedDate { get; set; }

    public virtual Account? Account { get; set; }
}
