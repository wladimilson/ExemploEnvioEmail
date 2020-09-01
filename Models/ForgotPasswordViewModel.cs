using System.ComponentModel.DataAnnotations;

namespace ExemploEnvioEmail.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}