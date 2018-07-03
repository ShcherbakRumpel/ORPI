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
            UpdateAdFile(PathConst.ADFILE);
        }

        private void UpdateAgency(String path)//
        {
            FTPConnectionManager connectionManager = CeateConnectionManager(PathConst.AGENCYZIP, PathConst.AGENCYZIP);
            //new FTPConnectionManager($"{PathConst.ORPI}{DayOfWeekEnum.SUN.ToString()}/{PathConst.AGENCYZIP}");
            List<String> list = TextToModelHelper.ToModel(PathConst.TXTFILEPATH + "/"+path);//change path
            IEnumerable<Agency> agencyList = TextToModelHelper.ModelAgency(list);

            foreach (var agency in agencyList)
            {
                uow.AgencyRepository.InsertOrUpdate(agency);
            }

            //Parallel.ForEach(agencyList, agency =>
            //{
            //    uow.AgencyRepository.InsertOrUpdate(agency);
            //});

            uow.SaveChanges();
        }

        private void UpdateAdFile(String path)
        {
            try
            {
                FTPConnectionManager connectionManager = CeateConnectionManager(PathConst.ADFILEZIP, PathConst.ADFILEZIP);
            }
            catch { }
            finally
            {
                List<String> list = TextToModelHelper.ToModel(PathConst.TXTFILEPATH + "/" + path);//change path
                IEnumerable<AdFile> adFileList = TextToModelHelper.ModelAdFile(list);

                foreach (var adFile in adFileList)
                {
                    uow.AdFileRepository.InsertOrUpdate(adFile);
                }

                //Parallel.ForEach(adFileList, adFile =>
                //{
                //    uow.AdFileRepository.InsertOrUpdate(adFile);
                //});

                uow.SaveChanges();
            }

        }

        private FTPConnectionManager CeateConnectionManager(String fileName, String zipFile)
        {
            DateTime dateNow = DateTime.Now;
            FTPConnectionManager connectionManager;
            switch (dateNow.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    {
                        connectionManager = new FTPConnectionManager($"{PathConst.ORPI}{DayOfWeekEnum.MON.ToString()}/{fileName}", zipFile);
                        return connectionManager;
                    }
                case DayOfWeek.Tuesday:
                    {
                        connectionManager = new FTPConnectionManager($"{PathConst.ORPI}{DayOfWeekEnum.TUE.ToString()}/{fileName}", zipFile);
                        return connectionManager;
                    }
                case DayOfWeek.Wednesday:
                    {
                        connectionManager = new FTPConnectionManager($"{PathConst.ORPI}{DayOfWeekEnum.WED.ToString()}/{fileName}", zipFile);
                        return connectionManager;
                    }
                case DayOfWeek.Thursday:
                    {
                        connectionManager = new FTPConnectionManager($"{PathConst.ORPI}{DayOfWeekEnum.THU.ToString()}/{fileName}", zipFile);
                        return connectionManager;
                    }
                case DayOfWeek.Friday:
                    {
                        connectionManager = new FTPConnectionManager($"{PathConst.ORPI}{DayOfWeekEnum.FRI.ToString()}/{fileName}", zipFile);
                        return connectionManager;
                    }
                case DayOfWeek.Saturday:
                    {
                        connectionManager = new FTPConnectionManager($"{PathConst.ORPI}{DayOfWeekEnum.SAT.ToString()}/{fileName}", zipFile);
                        return connectionManager;
                    }
                case DayOfWeek.Sunday:
                    {
                        connectionManager = new FTPConnectionManager($"{PathConst.ORPI}{DayOfWeekEnum.SUN.ToString()}/{fileName}", zipFile);
                        return connectionManager;
                    }
                default:
                    return null;
            }
        }
    }
}
