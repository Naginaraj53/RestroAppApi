using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Comman
{
    public class CommanModel
    {
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? modifiedDate { get; set; }
        public string modifiedBy { get; set; }

    }
}
