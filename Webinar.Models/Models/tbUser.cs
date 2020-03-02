using System.ComponentModel.DataAnnotations;

namespace Webinar.Models
{
    public class tbUser : BaseModel
    {
        [Required]
        public int Id { get; set; }
        
        [StringLength(100)]
        public string FirstName { get; set; }
        
        [StringLength(100)]
        public string LastName { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Username { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        public spUserType UserType { get; set; }
        public int UserTypeId { get; set; }
    }
}
