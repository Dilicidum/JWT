using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models.Responses;
namespace BLL.Interfaces
{
    public interface  ILoginService
    {
        Task<TokenResponse> CreateAccessTokenAsync(string email, string password);
        Task<TokenResponse> RefreshTokenAsync(string refreshToken, string userEmail);
        void RevokeRefreshToken(string refreshToken);
    }
}
