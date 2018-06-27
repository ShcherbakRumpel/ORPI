using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORPI.Web.Repository.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IAgencyRepository AgencyRepository { get; set; }
        IAdFileRepository AdFileRepository { get; set; }
        Int32 SaveChanges();
    }
}
