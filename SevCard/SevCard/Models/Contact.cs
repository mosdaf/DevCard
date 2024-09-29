using System.ComponentModel.DataAnnotations;

namespace SevCard.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری‌ست.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری‌ست.")]
        [EmailAddress(ErrorMessage = "فرمت ایمیل نادرست است.")]
        public string Email { get; set; }
        public string Service { get; set; }
        public string Message { get; set; }
    }
}
