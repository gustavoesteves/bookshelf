using System.ComponentModel.DataAnnotations;

namespace Bookshelf.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}