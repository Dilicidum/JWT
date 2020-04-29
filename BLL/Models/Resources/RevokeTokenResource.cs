using System.ComponentModel.DataAnnotations;

namespace BLL.Models.Resources
{
    public class RevokeTokenResource
    {
        [Required]
        public string Token { get; set; }
    }
}
