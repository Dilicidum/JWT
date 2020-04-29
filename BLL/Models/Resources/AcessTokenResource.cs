using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models.Resources
{
    public class AccessTokenResource
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public long Expiration { get; set; }
    }
}
