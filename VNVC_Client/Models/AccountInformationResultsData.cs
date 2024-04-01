using Newtonsoft.Json;

namespace VNVC_Client.Models
{
    public class AccountInformationResultsData
    {
        [JsonProperty("data")]
        public AccountInformationModelAPI Data { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
