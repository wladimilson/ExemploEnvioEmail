using System.ComponentModel.DataAnnotations;

namespace ExemploEnvioEmail.Models
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}