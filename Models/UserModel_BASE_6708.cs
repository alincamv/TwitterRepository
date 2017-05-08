using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class UserModel
    {   [Key]
        public int Id { get; set; }

        [Required]
        [RegularExpression("")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("^([a-zA-Z0-9_\\-\\.]+)@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,3})$", ErrorMessage = "Email is not a valid e-mail address.")]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfRegistration { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public string Location { get; set; }
    }
}
