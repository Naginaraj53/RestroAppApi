using Core.Comman;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class BookTable : CommanModel
    {
        public int BookTableId { get; set; }
        public string CandidateName { get; set; }
        public string CandidateEmail { get; set; }
        public string CandidateMobileNo { get; set; }
        public string CondidateMessage { get; set; }
        public DateTime? CondidateTime { get; set; }
    }
}
