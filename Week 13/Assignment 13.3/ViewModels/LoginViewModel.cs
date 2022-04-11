using System.ComponentModel.DataAnnotations;
namespace Assignment_13._3.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter user name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
