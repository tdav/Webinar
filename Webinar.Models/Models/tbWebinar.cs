using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Webinar.Models
{
    public class tbWebinar : BaseModel
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Required]
        public string Title { get; set; }

        [StringLength(100)]
        public ICollection<tbUser> Teachers { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(255)]
        public string Url { get; set; }

        [StringLength(255)]
        public string ImageUrl { get; set; }

        public tbRoom Room { get; set; }

        public ICollection<spWebinarAccess> Accsses { get; set; }

        public int WebinarTypeId { get; set; }
        public spWebinarType WebinarType { get; set; }
    }
}
