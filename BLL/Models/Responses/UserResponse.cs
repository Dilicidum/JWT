using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models.DTO;
namespace BLL.Models.Responses
{
    public class UserResponse:BaseResponse
    {
        public UserDTO User { get; set; }
        public UserResponse(UserDTO user,bool Sucess,string Message) : base(Sucess, Message) 
        { 
            User = user; 
        }
    }
}
