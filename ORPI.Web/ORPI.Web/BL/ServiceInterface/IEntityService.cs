using ORPI.Web.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORPI.Web.BL.ServiceInterface
{
    public interface IEntityService
    {
        IEnumerable<AdFile> GetAllAdFile();
        Boolean ManualUpdateAgency();
        Boolean ManualUpdateAdFile();
        void UpdateOpri();
    }
}
