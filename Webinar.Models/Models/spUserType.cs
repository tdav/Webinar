using System.ComponentModel.DataAnnotations;

namespace Webinar.Models
{
    public class spUserType : BaseModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
