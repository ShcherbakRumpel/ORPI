using Microsoft.EntityFrameworkCore;
using ORPI.Web.DAL.Models;
using ORPI.Web.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORPI.Web.Repository.Concrete
{
    public class AdFileRepository : EFGenericRepository<AdFile>, IAdFileRepository
    {
        public AdFileRepository(DbContext context) : base(context)
        {
        }

        public void InsertOrUpdate(AdFile item)
        {
            var existingAdFile = Query.Where(s => s.AdFileId == item.AdFileId).FirstOrDefault();
            if (existingAdFile == null)
            {
                Create(item);
            }
            else
            {
                Update(existingAdFile);
            }
        }
    }
}
