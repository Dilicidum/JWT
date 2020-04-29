using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models.Security;
using DAL.Entities;
namespace BLL.Interfaces
{
    public interface ITokenHandler
    {
        AccessToken CreateAccessToken(User user);
        RefreshToken TakeRefreshToken(string token);
        void RevokeRefreshToken(string token);
    }
}
