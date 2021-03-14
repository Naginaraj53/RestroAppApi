using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
     public interface IHederRepository
     {
       Task<TopHeader> DALGetTopHeaderData();
     }
}
