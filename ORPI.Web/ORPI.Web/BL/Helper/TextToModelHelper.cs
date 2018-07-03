using ORPI.Web.DAL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ORPI.Web.BL.Helper
{
    public static class TextToModelHelper
    {
        public static List<String> ToModel(String path)
        {
            List<String> strList = new List<String>();
            String str = StreamHelper.GetStringFromFile(path);

            Regex regex = new Regex("\"[^\"]*\"");
            Match match = regex.Match(str);

            //Int32 count = 0;
            while (match.Success)
            {
                strList.Add(match.Value.Trim('"'));
                match = match.NextMatch();
                //count++;
            }
            return strList;
        }

        public static List<Agency> ModelAgency(List<String> strList)
        {
            List<Agency> listAgency = new List<Agency>();
            Boolean isFullModel = false;
            Agency agency = new Agency();
            Int32 lastElem = strList.Count;

            #region agency
            for (int i = 0; i <= strList.Count; i++)
            {
                if (lastElem == 0)
                {
                    listAgency.Add(agency);
                    break;
                }
                if (isFullModel)
                {
                    listAgency.Add(agency);
                    agency = new Agency();
                    isFullModel = false;

                }
                if (agency.AgencyId == null)
                {
                    agency.AgencyId = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.AgencyName == null)
                {
                    agency.AgencyName = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Address1 == null)
                {
                    agency.Address1 = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Address2 == null)
                {
                    agency.Address2 = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.PostalCode == null)
                {
                    agency.PostalCode = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.City == null)
                {
                    agency.City = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Phone == null)
                {
                    agency.Phone = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Fax == null)
                {
                    agency.Fax = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Fax == null)
                {
                    agency.Fax = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.OpriId == null)
                {
                    agency.OpriId = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Email == null)
                {
                    agency.Email = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Website == null)
                {
                    agency.Website = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.GIEId == null)
                {
                    agency.GIEId = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Siret == null)
                {
                    agency.Siret = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.AgancyImage == null)
                {
                    agency.AgancyImage = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Civilite == null)
                {
                    agency.Civilite = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.LegalRepresentative == null)
                {
                    agency.LegalRepresentative = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Raisonsosiale == null)
                {
                    agency.Raisonsosiale = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.LegalForm == null)
                {
                    agency.LegalForm = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.OfficeAddress == null)
                {
                    agency.OfficeAddress = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Capital == null)
                {
                    agency.Capital = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.NumberRCSN == null)
                {
                    agency.NumberRCSN = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.CommercialCourt == null)
                {
                    agency.CommercialCourt = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.VATRate == null)
                {
                    agency.VATRate = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.ProfessionalCardNumber == null)
                {
                    agency.ProfessionalCardNumber = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Prefecture == null)
                {
                    agency.Prefecture = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.PrefectureAddress == null)
                {
                    agency.PrefectureAddress = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.GuaranteeBody == null)
                {
                    agency.GuaranteeBody = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.AgencyAddress == null)
                {
                    agency.AgencyAddress = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.WarrantyStatement == null)
                {
                    agency.WarrantyStatement = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.WarrantySize == null)
                {
                    agency.WarrantySize = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Null01 == null)
                {
                    agency.Null01 = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Null02 == null)
                {
                    agency.Null02 = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Null03 == null)
                {
                    agency.Null03 = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Null04 == null)
                {
                    agency.Null04 = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.AgencyScheduleURL == null)
                {
                    agency.AgencyScheduleURL = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Null06 == null)
                {
                    agency.Null06 = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Null07 == null)
                {
                    agency.Null07 = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Null08 == null)
                {
                    agency.Null08 = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Null09 == null)
                {
                    agency.Null09 = strList[i];
                    lastElem--;
                    continue;
                }
                if (agency.Null10 == null)
                {
                    agency.Null10 = strList[i];
                    isFullModel = true;
                    lastElem--;
                    continue;
                }
            }
            #endregion
            return listAgency;
        }

        public static List<AdFile> ModelAdFile(List<String> strList)
        {
            List<AdFile> listAdFile = new List<AdFile>();
            Boolean isFullModel = false;
            AdFile adFile = new AdFile();
            Int32 lastElem = strList.Count;

            #region adFile
            for (int i = 0; i <= strList.Count; i++)
            {
                if (lastElem == 0)
                {
                    listAdFile.Add(adFile);
                    break;
                }
                if (isFullModel)
                {
                    listAdFile.Add(adFile);
                    adFile = new AdFile();
                }
                if (adFile.AdFileId == null)
                {
                    adFile.AdFileId = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.AgencyId == null)
                {
                    adFile.AgencyId = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.TypeOfOwnership == null)
                {
                    adFile.TypeOfOwnership = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.PostalCode == null)
                {
                    adFile.PostalCode = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.City == null)
                {
                    adFile.City = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Title == null)
                {
                    adFile.Title = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Price == null)
                {
                    adFile.Price = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.LivingArea == null)
                {
                    adFile.LivingArea = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.NumberOfRooms == null)
                {
                    adFile.NumberOfRooms = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.NumberOfChamber == null)
                {
                    adFile.NumberOfChamber = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.ShortAdvertisement == null)
                {
                    adFile.ShortAdvertisement = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo1 == null)
                {
                    adFile.Photo1 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo2 == null)
                {
                    adFile.Photo2 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo3 == null)
                {
                    adFile.Photo3 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo4 == null)
                {
                    adFile.Photo4 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo5 == null)
                {
                    adFile.Photo5 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.TypeOfMandate == null)
                {
                    adFile.TypeOfMandate = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.GIEId == null)
                {
                    adFile.GIEId = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Square == null)
                {
                    adFile.Square = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.NumberOfMandate == null)
                {
                    adFile.NumberOfMandate = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.LandType == null)
                {
                    adFile.LandType = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.VirtualPartnersURL == null)
                {
                    adFile.VirtualPartnersURL = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.BuildType == null)
                {
                    adFile.BuildType = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.AmountOfCommissionTTC == null)
                {
                    adFile.AmountOfCommissionTTC = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.RentTTC == null)
                {
                    adFile.RentTTC = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.AdvertisingInEnglish == null)
                {
                    adFile.AdvertisingInEnglish = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.AdvertisingInFrench == null)
                {
                    adFile.AdvertisingInFrench = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.InsuranceDeposit == null)
                {
                    adFile.InsuranceDeposit = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Rent == null)
                {
                    adFile.Rent = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.AreaSurface == null)
                {
                    adFile.AreaSurface = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.AdvertisingPoster == null)
                {
                    adFile.AdvertisingPoster = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.GeneralAvailabilityOfHousing == null)
                {
                    adFile.GeneralAvailabilityOfHousing = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.NumberOfFloor == null)
                {
                    adFile.NumberOfFloor = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.TypeOfBuilding == null)
                {
                    adFile.TypeOfBuilding = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null1 == null)
                {
                    adFile.Null1 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null2 == null)
                {
                    adFile.Null2 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null3 == null)
                {
                    adFile.Null3 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null4 == null)
                {
                    adFile.Null4 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null5 == null)
                {
                    adFile.Null5 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo6 == null)
                {
                    adFile.Photo6 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo7 == null)
                {
                    adFile.Photo7 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo8 == null)
                {
                    adFile.Photo8 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo9 == null)
                {
                    adFile.Photo9 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo10 == null)
                {
                    adFile.Photo10 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo11 == null)
                {
                    adFile.Photo11 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo12 == null)
                {
                    adFile.Photo12 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo13 == null)
                {
                    adFile.Photo13 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo14 == null)
                {
                    adFile.Photo14 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo15 == null)
                {
                    adFile.Photo15 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo16 == null)
                {
                    adFile.Photo16 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo17 == null)
                {
                    adFile.Photo17 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo18 == null)
                {
                    adFile.Photo18 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo19 == null)
                {
                    adFile.Photo19 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Photo20 == null)
                {
                    adFile.Photo20 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.RentOfFurniture == null)
                {
                    adFile.RentOfFurniture = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.JointLease == null)
                {
                    adFile.JointLease = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.AnnualFee == null)
                {
                    adFile.AnnualFee = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.IndefiniteJointOwnership == null)
                {
                    adFile.IndefiniteJointOwnership = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null100 == null)
                {
                    adFile.Null100 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null101 == null)
                {
                    adFile.Null101 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null102 == null)
                {
                    adFile.Null102 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null103 == null)
                {
                    adFile.Null103 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null104 == null)
                {
                    adFile.Null104 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null105 == null)
                {
                    adFile.Null105 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null106 == null)
                {
                    adFile.Null106 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null107 == null)
                {
                    adFile.Null107 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null108 == null)
                {
                    adFile.Null108 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null109 == null)
                {
                    adFile.Null109 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null110 == null)
                {
                    adFile.Null110 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null111 == null)
                {
                    adFile.Null111 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null112 == null)
                {
                    adFile.Null112 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null113 == null)
                {
                    adFile.Null113 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null114 == null)
                {
                    adFile.Null114 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null115 == null)
                {
                    adFile.Null115 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null116 == null)
                {
                    adFile.Null116 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null117 == null)
                {
                    adFile.Null117 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null118 == null)
                {
                    adFile.Null118 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null119 == null)
                {
                    adFile.Null119 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null120 == null)
                {
                    adFile.Null120 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null121 == null)
                {
                    adFile.Null121 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null122 == null)
                {
                    adFile.Null122 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null123 == null)
                {
                    adFile.Null123 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null124 == null)
                {
                    adFile.Null124 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null125 == null)
                {
                    adFile.Null125 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null126 == null)
                {
                    adFile.Null126 = strList[i];
                    lastElem--;
                    continue;
                }
                if (adFile.Null127 == null)
                {
                    adFile.Null127 = strList[i];
                    isFullModel = true;
                    lastElem--;
                    continue;
                }
            }
            #endregion
            return listAdFile;
        }

    }


}
