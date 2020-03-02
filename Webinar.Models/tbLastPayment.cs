using System.ComponentModel.DataAnnotations;

namespace Webinar.Models
{
    public class tbLastPayment : BaseModel
    {
        public int Id { get; set; }

        [Required]
        public decimal Summa { get; set; }

        [Required]
        public int OnlinePaymentId { get; set; }
        public spOnlinePayment OnlinePayment { get; set; }
    }
}
