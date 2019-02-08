using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Response
{
    public class ResultResponse
    {
        public ResultResponse()
        {
            Messages = new List<string>();
        }
        public bool Success { get; set; }
        public object Data { get; set; }
        public List<string> Messages { get; set; }
    }
}
