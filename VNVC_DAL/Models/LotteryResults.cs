using System;
using System.Collections.Generic;

namespace VNVC_DAL.Models;

public partial class LotteryResults
{
    public Guid LotteryResultsID { get; set; }

    public DateTime? Slot { get; set; }

    public int? Result { get; set; }

    public DateTime? InsertedDate { get; set; }
}
