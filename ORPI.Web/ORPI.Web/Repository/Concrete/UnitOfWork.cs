using Microsoft.EntityFrameworkCore;
using ORPI.Web.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORPI.Web.Repository.Concrete
{
    public class UnitOfWork: IUnitOfWork
    {
        private DbContext context;

        public IAgencyRepository AgencyRepository { get; set; }
        public IAdFileRepository AdFileRepository { get; set; }

        public UnitOfWork(DbContext _context)
        {
            context = _context;

            AgencyRepository = new AgencyRepository(_context);
            AdFileRepository = new AdFileRepository(_context);
        }

        public Int32 SaveChanges()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
