using Microsoft.EntityFrameworkCore;
using ORPI.Web.DAL.Models;
using ORPI.Web.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORPI.Web.Repository.Concrete
{
    public class AgencyRepository : EFGenericRepository<Agency>, IAgencyRepository
    {
        public AgencyRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Agency> GetAll()
        {
            return Get();
        }

        public void InsertOrUpdate(Agency item)
        {
            var existingAgency = Query.Where(s=> s.AgencyId == item.AgencyId).FirstOrDefault();
            if (existingAgency == null)
            {
                Create(item);
            }
            else
            {
                Update(existingAgency);
            }
        }
    }
}
