using System;

namespace employeTracker.Models
{
    public class ErrorResponse
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public object ExtraData { get; set; }
    }
}
