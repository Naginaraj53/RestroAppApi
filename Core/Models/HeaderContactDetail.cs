using Core.Comman;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Models
{
    public class HeaderContactDetail : CommanModel
    {
        [Key]
        public int HContactDetailId { get; set; }
        public string HContactDetailName { get; set; }
        public string HContactDetailLink { get; set; }
        public string HContactDetailIcon { get; set; }
        public string HContactDetailValue { get; set; }
    }
}
