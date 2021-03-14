using BAL.IServices;
using Core.ViewModels;
using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class HeaderService : IHeaderService

    {
        private readonly IHederRepository _hederRepository;
        public HeaderService(IHederRepository hederRepository)
        {
            _hederRepository = hederRepository;
        }

        public async Task<TopHeader> BALGetTopHeaderData()
        {
            return await _hederRepository.DALGetTopHeaderData();
            
        }
    }
}
