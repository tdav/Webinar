using System.ComponentModel.DataAnnotations;

namespace Webinar.Models
{
    public class tbSetup : BaseModel
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string FontName { get; set; }
        
        [StringLength(100)]
        public string FontSize { get; set; }
       
        [StringLength(100)]
        public string Background { get; set; }
        
        [StringLength(100)]
        public string TextColor { get; set; }
        
        [StringLength(100)]
        public string TextToSpeech { get; set; }
        
        
        public bool IsTranslate { get; set; }
        
        [StringLength(100)]
        public string TranslateServer { get; set; }
        
        [StringLength(100)]
        public string TranslateToLang { get; set; }
    }
}
