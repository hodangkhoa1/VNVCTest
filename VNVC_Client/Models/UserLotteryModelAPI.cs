namespace VNVC_Client.Models
{
    public class UserLotteryModelAPI
    {
        public Guid LotteryResultsID { get; set; }

        public DateTime? Slot { get; set; }

        public int? Result { get; set; }

        public DateTime? InsertedDate { get; set; }
    }
}
