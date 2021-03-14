using Core;
using Core.ViewModels;
using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class HeaderRepository : IHederRepository
    {
        private readonly RestroDbContext _context;
        public HeaderRepository(RestroDbContext context)
        {
            _context = context;
        }

        public async Task<TopHeader> DALGetTopHeaderData()
        {
            var headerContact =  _context.HeaderContactDetails.ToList();
            var socialMedia = _context.SocialMedias.ToList();
            var linkType = _context.LinkContents.ToList();

            TopHeader topheaderVM = new TopHeader()
            {
                BookTables= linkType,
                SocialMedia=socialMedia,
                ContactDetail=headerContact
            };
           
            return  topheaderVM;
        }
    }
}
