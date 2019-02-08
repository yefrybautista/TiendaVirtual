using BLL.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class Response
    {
            public ResultResponse HandleException(Exception e)
            {
                var response = new ResultResponse { Success = false };
                response.Messages.Add(e.Message);
                if (e.InnerException != null)
                    response.Messages.Add(e.InnerException.Message);
                return response;
            }

            public ResultResponse Success(object data = null)
            {
                return new ResultResponse { Success = true, Data = data };
            }

            public ResultResponse Error(List<string> messages)
            {
                return new ResultResponse { Success = false, Messages = messages };
            }

            public ResultResponse ErrorMessage(string message)
            {
                var messages = new List<string>();
                messages.Add(message);
                return new ResultResponse { Success = false, Messages = messages };
            }
    }
}
