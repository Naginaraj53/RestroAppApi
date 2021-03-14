using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ViewModels
{
    public class TopHeader
    {
        public TopHeader()
        {

        }
        public virtual IEnumerable<LinkContent> BookTables { get; set; }
        public virtual IEnumerable<HeaderContactDetail> ContactDetail { get; set; }
        public virtual IEnumerable<SocialMedia> SocialMedia { get; set; }

    }
}
