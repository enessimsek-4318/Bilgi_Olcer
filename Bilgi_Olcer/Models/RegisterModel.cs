using System.ComponentModel.DataAnnotations;

namespace Bilgi_Olcer.Models
{
    public class RegisterModel
    {

        public string FullName { get; set; }

        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
