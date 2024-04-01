using Newtonsoft.Json;

namespace VNVC_Client.Models
{
    public class ResponseLotteryResultsData
    {
        [JsonProperty("data")]
        public List<LotteryResultsModelAPI> Data { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
