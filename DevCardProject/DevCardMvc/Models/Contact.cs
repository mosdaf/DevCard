using System.ComponentModel.DataAnnotations;

namespace DevCardMvc.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است.")]
        [MinLength(1,ErrorMessage = "حداقل سه کاراکتر")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "ایمیل صحیح نیست.")]
        [Required(ErrorMessage = "این فیلد اجباری است.")]
        public string Email { get; set; }
        public string Services { get; set; }
        public string Message { get; set; }
    }
}
