using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GC_CS_Lab18_CoffeeShop.Models
{
    public class RegisterUser
    {
        [Required(ErrorMessage ="Username is required")]
        [StringLength(100,MinimumLength = 8)]
        public string UserName { get; set; }
        [RegularExpression(@"\b.{2,}@.{2,}\..{2,3}\b")]
        public string Email { get; set; }
        public string EmailType { get; set; }

        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }
        public int GCCoffeeLove { get; set; }

        public RegisterUser() { }
        public RegisterUser(string username, string email, string emailtype, string pw, int coffeelove)
        {
            UserName = username;
            Email = email;
            Password = pw;
            EmailType = emailtype;
            GCCoffeeLove = coffeelove;
        }
    }
}
