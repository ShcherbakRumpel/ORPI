using ORPI.Web.BL.Helper;
using ORPI.Web.BL.ServiceInterface;
using ORPI.Web.DAL.Models;
using ORPI.Web.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORPI.Web.BL.Services
{
    public class EntityService : IEntityService
    {
        private IUnitOfWork uow;

        public EntityService(IUnitOfWork _uow)
        {
            uow = _uow;
        }

        public Boolean UpdateAgency(String path)//
        {
            List<String> list = TextToModelHelper.ToModel("path_to_file");//change path
            IEnumerable<Agency> agencyList = TextToModelHelper.ModelAgency(list);

            Parallel.ForEach(agencyList, agency =>
            {
                uow.AgencyRepository.InsertOrUpdate(agency);
            });
            
            return uow.SaveChanges() >=0;
        }

        public Boolean UpdateAdFile()
        {
            return true;
        }
    }
}
