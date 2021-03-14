using BAL.IServices;
using Core.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeaderController : ControllerBase
    {
        private readonly IHeaderService _headerService;
        public HeaderController(IHeaderService headerService)
        {
            _headerService = headerService;
        }

        [HttpGet]
        public async Task<TopHeader> GetTopHeaderData()
        {
            try
            {
               return  await _headerService.BALGetTopHeaderData();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
