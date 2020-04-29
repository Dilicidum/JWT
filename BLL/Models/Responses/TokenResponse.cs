using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models.Security;
namespace BLL.Models.Responses
{
    public class TokenResponse : BaseResponse
    {
        public AccessToken Token { get; set; }

        public TokenResponse(bool success, string message, AccessToken token) : base(success, message)
        {
            Token = token;
        }
    }
}
