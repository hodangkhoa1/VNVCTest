namespace VNVC_BAL.Models
{
    public class LotteryResultsInformationDTO
    {
        public Guid LotteryResultsID { get; set; }

        public DateTime? Slot { get; set; }

        public int? Result { get; set; }

        public DateTime? InsertedDate { get; set; }
    }
}
