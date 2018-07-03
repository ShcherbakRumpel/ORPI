using ORPI.Web.BL.Const;
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
        private Object lockObj = new Object();

        public EntityService(IUnitOfWork _uow)
        {
            uow = _uow;
        }

        public void UpdateOpri()
        {

            UpdateAgency(PathConst.AGENCY);
            //UpdateAdFile(PathConst.ADFILE);
        }

        private void UpdateAgency(String path)//
        {
            //FTPConnectionManager connectionManager = CeateConnectionManager(PathConst.AGENCYZIP);
            //new FTPConnectionManager($"{PathConst.ORPI}{DayOfWeekEnum.SUN.ToString()}/{PathConst.AGENCYZIP}");
            List<String> list = TextToModelHelper.ToModel(PathConst.TXTFILEPATH + "/"+path);//change path
            IEnumerable<Agency> agencyList = TextToModelHelper.ModelAgency(list);

            var qwe =  uow.AgencyRepository.GetAll();

            //foreach(var agency in agencyList)
            //{
            //    uow.AgencyRepository.InsertOrUpdate(agency);
            //}

            //Parallel.ForEach(agencyList, agency =>
            //{
            //    uow.AgencyRepository.InsertOrUpdate(agency);
            //});
            
            uow.SaveChanges();
        }

        private void UpdateAdFile(String path)
        {
            FTPConnectionManager connectionManager = CeateConnectionManager(PathConst.ADFILEZIP);
            List<String> list = TextToModelHelper.ToModel(PathConst.TXTFILEPATH +"/"+ path);//change path
            IEnumerable<AdFile> adFileList = TextToModelHelper.ModelAdFile(list);

            Parallel.ForEach(adFileList, adFile =>
            {
                uow.AdFileRepository.InsertOrUpdate(adFile);
            });

            uow.SaveChanges();
        }

        private FTPConnectionManager CeateConnectionManager(String fileName)
        {
            DateTime dateNow = DateTime.Now;
            FTPConnectionManager connectionManager;
            switch (dateNow.DayOfWeek)
            {
                //case DayOfWeek.Monday:
                //    {
                //        connectionManager = new FTPConnectionManager($"{PathConst.ORPI}{DayOfWeekEnum.MON.ToString()}/{fileName}");
                //        return connectionManager;
                //    }
                //case DayOfWeek.Tuesday:
                //    {
                //        connectionManager = new FTPConnectionManager($"{PathConst.ORPI}{DayOfWeekEnum.TUE.ToString()}/{fileName}");
                //        return connectionManager;
                //    }
                //case DayOfWeek.Wednesday:
                //    {
                //        connectionManager = new FTPConnectionManager($"{PathConst.ORPI}{DayOfWeekEnum.WED.ToString()}/{fileName}");
                //        return connectionManager;
                //    }
                //case DayOfWeek.Thursday:
                //    {
                //        connectionManager = new FTPConnectionManager($"{PathConst.ORPI}{DayOfWeekEnum.THU.ToString()}/{fileName}");
                //        return connectionManager;
                //    }
                //case DayOfWeek.Friday:
                //    {
                //        connectionManager = new FTPConnectionManager($"{PathConst.ORPI}{DayOfWeekEnum.FRI.ToString()}/{fileName}");
                //        return connectionManager;
                //    }
                //case DayOfWeek.Saturday:
                //    {
                //        connectionManager = new FTPConnectionManager($"{PathConst.ORPI}{DayOfWeekEnum.SAT.ToString()}/{fileName}");
                //        return connectionManager;
                //    }
                case DayOfWeek.Sunday:
                    {
                        connectionManager = new FTPConnectionManager($"{PathConst.ORPI}{DayOfWeekEnum.SUN.ToString()}/{fileName}");
                        return connectionManager;
                    }
                default:
                    return null;
            }
        }
    }
}
