using System.ComponentModel.DataAnnotations;

namespace Webinar.Models
{
    public class spWebinarAccess : BaseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //public bool IsWebCamera { get; set; }
        //public bool IsAudio { get; set; }
        //public bool IsDesktop { get; set; }
        //public bool IsDocumetPublish{ get; set; }
        //public bool IsSite{ get; set; }
    }
}
