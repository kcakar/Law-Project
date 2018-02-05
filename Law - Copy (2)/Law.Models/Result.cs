using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
    public class Result
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string TechnicalMessage { get; set; }

        public Result(string Message, bool Success, string TechnicalMessage)
        {
            this.Message = Message;
            this.Success = Success;
            this.TechnicalMessage = TechnicalMessage;
        }
    }
}
