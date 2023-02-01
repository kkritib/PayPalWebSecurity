using System.ComponentModel.DataAnnotations;

namespace PayPalWebSecurity.ViewModels
{
    public class UserVM
    {
        [Key]
        public string Email { get; set; }
    }
}
