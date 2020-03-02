using System.ComponentModel.DataAnnotations;

namespace Webinar.Models
{
    public class viAuthenticateModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
