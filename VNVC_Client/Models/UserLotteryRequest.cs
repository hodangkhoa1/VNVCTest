namespace VNVC_Client.Models
{
    public class UserLotteryRequest
    {
        public Guid? AccountID { get; set; }

        public DateTime? Slot { get; set; }

        public int? Result { get; set; }
    }
}
