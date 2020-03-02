using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Webinar.Models
{
    public class tbBilling : BaseModel
    {
        public int Id { get; set; }

        [Required]
        public bool IsPayed { get; set; }

        [Required]
        public decimal BalanceSumma { get; set; }
        public ICollection<tbLastPayment> Payments { get; set; }

    }
}
