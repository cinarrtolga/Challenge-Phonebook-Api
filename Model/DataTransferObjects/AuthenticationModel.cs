using System.ComponentModel.DataAnnotations;

namespace Model.DataTransferObjects
{
    public class AuthenticationModel {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }    
}