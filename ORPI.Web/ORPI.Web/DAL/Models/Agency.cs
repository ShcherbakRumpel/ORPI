using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORPI.Web.DAL.Models
{
    public class Agency
    {
        public String AgencyId { get; set; }//CODEAGE
        public String AgencyName { get; set; }//AGENCE ??
        public String Address1 { get; set; }//ADRESSE1
        public String Address2 { get; set; }//ADRESSE2
        public String PostalCode { get; set; }//CP
        public String City { get; set; }//VILLE
        public String Phone { get; set; }//TELEPHONE
        public String Fax { get; set; }//FAX
        public String OpriId { get; set; }//KEY
        public String Email { get; set; }//EMAIL
        public String Website { get; set; } //WEBSITE
        public String GIEId { get; set; } // GIEKEY
        public String Siret { get; set; }//SIRET
        public String AgancyImage { get; set; }//OFFICEPHOTO
        public String Civilite { get; set; }//CIVILITE
        public String LegalRepresentative { get; set; }//NOMLEGALREP
        public String Raisonsosiale { get; set; }//??? RAISONSOCIALE
        public String LegalForm { get; set; } //FORME
        public String OfficeAddress { get; set; } //ADRESSE
        public String Capital { get; set; } // CAPITAL
        public String NumberRCSN { get; set; } //RCS
        public String CommercialCourt { get; set; }//TRIBUNAL
        public String VATRate { get; set; } //TVA
        public String ProfessionalCardNumber { get; set; }//CARTEPRO
        public String Prefecture { get; set; }//PREFECTURE
        public String PrefectureAddress { get; set; }//ADRESSEPREF
        public String GuaranteeBody { get; set; }//GARANTIE
        public String AgencyAddress { get; set; }//ADRESSEGAR
        public String WarrantyStatement { get; set; }//MENTION
        public String WarrantySize { get; set; }//MONTANTGAR
        public String Null01 { get; set; }//NULL01
        public String Null02 { get; set; }//NULL02
        public String Null03 { get; set; }//NULL03
        public String Null04 { get; set; }//NULL04
        public String AgencyScheduleURL { get; set; }//BAREME
        public String Null06 { get; set; }//NULL06
        public String Null07 { get; set; }//NULL07
        public String Null08 { get; set; }//NULL08
        public String Null09 { get; set; }//NULL09
        public String Null10 { get; set; }//NULL10
    }
}
