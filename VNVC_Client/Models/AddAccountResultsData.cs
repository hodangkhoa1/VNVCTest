using Newtonsoft.Json;

namespace VNVC_Client.Models
{
    public class AddAccountResultsData
    {
        [JsonProperty("data")]
        public object Data { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
