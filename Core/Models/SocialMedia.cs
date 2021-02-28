using Core.Comman;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class SocialMedia :CommanModel
    {
        public int SocialMediaId { get; set; }
        public string SocialMediaName { get; set; }
        public string SocialMediaImage { get; set; }
        public string SocialMediaLink { get; set; }
        public string SocialMediaFaClass{ get; set; }
       
    }
}
