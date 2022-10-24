using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelProject.MVC.Areas.Member.Models
{
    public class UserEditViewModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Password { get; set; }
        public int ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string ImageUrl { get; set; }
    }
}
