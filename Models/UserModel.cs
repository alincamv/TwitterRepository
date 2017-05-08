using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class UserModel

    {
        [RegularExpression("^([0]\\d{8})|([+]\\d{11})",
            ErrorMessage = "You've entered the wrong format number")]
        public string PhoneNumber { get; set; }

        public string Avatar { get; set; }

        public int Id { get; set; }

        [Required]
        [RegularExpression("^([A-Za-z]{3,25})\\s([A-Za-z]{3,25})",
            ErrorMessage = "* Please enter your full name")]
        public string FullName { get; set; }

        [Required]
        [RegularExpression("^([a-zA-Z0-9_\\-\\.]+)@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,3})$",
            ErrorMessage = "* Email is not a valid e-mail address.")]
        public string Email { get; set; }


        [Required]
        [RegularExpression("^[\\._a-zA-Z0-9]{3,30}",
            ErrorMessage = "* Username can contain folowing characters:_,A-Z,0-9")]
        public string Username { get; set; }

        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[\\.#?!@$%^&*-]).{6,}$",
            ErrorMessage = "The password must contain: A-Z,a-z,0-9,.@#$%^&*" +
                           "The minimum length should be 6 characters")]
        public string Password { get; set; }

        public string Location { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime? DateOfRegistration { get; set; }

        public virtual ICollection<TweetModel> Tweet { get; set; }
    }
}