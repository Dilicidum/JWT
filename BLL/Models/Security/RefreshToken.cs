using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models.Security
{
    public class RefreshToken : JsonWebToken
    {
        public RefreshToken(string token, long expiration) : base(token, expiration)
        {
        }
    }
}
