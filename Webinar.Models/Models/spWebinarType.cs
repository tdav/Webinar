using System.ComponentModel.DataAnnotations;

namespace Webinar.Models
{
    public class spWebinarType : BaseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
