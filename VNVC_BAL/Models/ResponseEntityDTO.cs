using VNVC_BAL.Enums;
using VNVC_BAL.Utils;

namespace VNVC_BAL.Models
{
    public class ResponseEntityDTO(object? data, bool status, string message)
    {
        public object? Data { get; set; } = data;

        public bool Status { get; set; } = status;

        public string Message { get; set; } = message;
    }
}
