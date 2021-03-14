using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace BAL.IServices
{
    public interface IHeaderService
    {
       Task<TopHeader> BALGetTopHeaderData();
    }
}
