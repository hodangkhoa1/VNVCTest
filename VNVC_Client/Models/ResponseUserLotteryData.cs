using Newtonsoft.Json;

namespace VNVC_Client.Models
{
    public class ResponseUserLotteryData
    {
        [JsonProperty("data")]
        public List<UserLotteryModelAPI> Data { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
