using System.ComponentModel.DataAnnotations;

namespace ShohagOnlinePortal.Models
{
    public class SubmitMeContact
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Mobile No")]
        public string MobileNo { get; set; }
        [Required]
        public string Message { get; set; }
    }
}