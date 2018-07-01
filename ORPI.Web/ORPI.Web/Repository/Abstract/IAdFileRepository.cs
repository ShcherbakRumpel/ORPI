using ORPI.Web.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORPI.Web.Repository.Abstract
{
    public interface IAdFileRepository
    {
        void InsertOrUpdate(AdFile item);
    }
}
