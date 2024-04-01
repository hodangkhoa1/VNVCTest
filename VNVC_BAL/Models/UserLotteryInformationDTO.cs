namespace VNVC_BAL.Models
{
    public class UserLotteryInformationDTO
    {
        public Guid UserLotteryID { get; set; }

        public DateTime? Slot { get; set; }

        public int? Result { get; set; }

        public DateTime? InsertedDate { get; set; }
    }
}
