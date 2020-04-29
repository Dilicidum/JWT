using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models.Responses
{
    public class BaseResponse
    {
        public bool Sucess { get; set; }
        public string Message { get; set; }
        public BaseResponse(bool Sucess,string Message)
        {
            this.Sucess = Sucess;
            this.Message = Message;
        }
    }
}
