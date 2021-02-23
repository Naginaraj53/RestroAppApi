using Core.Comman;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class User : CommanModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileNo { get; set; }
    }
}
