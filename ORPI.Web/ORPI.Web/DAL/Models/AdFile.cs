using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORPI.Web.DAL.Models
{
    public class AdFile
    {
        public String AdFileId { get; set; } // REF_ANNONCE
        public String AgencyId { get; set; } //AGENCYNUMBER
        public String TypeOfOwnership { get; set; } //BIEN
        public String PostalCode { get; set; }//CP
        public String City { get; set; }//VILLE
        public String Title { get; set; } //TITRE
        public String Price { get; set; } //PRIX
        public String LivingArea { get; set; }//SURFACE
        public String NumberOfRooms { get; set; } //NB_PIECES
        public String NumberOfChamber { get; set; } //NB_CHAMBRES
        public String ShortAdvertisement { get; set; } //PUB_COURTE
        public String Photo1 { get; set; } //PHOTO1
        public String Photo2 { get; set; } //PHOTO2
        public String Photo3 { get; set; } //PHOTO3
        public String Photo4 { get; set; } //PHOTO4
        public String Photo5 { get; set; } //PHOTO5
        public String TypeOfMandate { get; set; }//TYPE DE MANDAT
        public String GIEId { get; set; } // GIEKEY
        public String Square { get; set; } //LIVINGROOMSURFACE
        public String NumberOfMandate { get; set; }//LISTINGCONTRACTNUMBER
        public String LandType { get; set; } //LANDTYPE
        public String VirtualPartnersURL { get; set; } //VIRTUALVIEWING
        public String BuildType { get; set; } //BUILDTYPE
        public String AmountOfCommissionTTC { get; set; } //RENTAGENCYTOTAL
        public String RentTTC { get; set; } //RENTAGENCYCOMMISSIONRENTER
        public String AdvertisingInEnglish { get; set; } //ADREMARKSLONGEN
        public String AdvertisingInFrench { get; set; } //PUB_LONGUE
        public String InsuranceDeposit { get; set; } //DEPOTGUARANTIE
        public String Rent { get; set; } //PROVISIONSCHARGESLOC
        public String AreaSurface { get; set; }//SURFPARCELLE
        public String AdvertisingPoster { get; set; } // PUCESAFFVITRINE
        public String GeneralAvailabilityOfHousing { get; set; }//BUILDINGLIVEABLESURFACE
        public String NumberOfFloor { get; set; } //STORIESBUILDING
        public String TypeOfBuilding { get; set; } //BUILDINGSTYLE
        public String Null1 { get; set; } //Null1
        public String Null2 { get; set; } //Null2
        public String Null3 { get; set; } //Null3
        public String Null4 { get; set; } //Null4
        public String Null5 { get; set; } //Null5
        public String Photo6 { get; set; } //PHOTO6
        public String Photo7 { get; set; } //PHOTO7
        public String Photo8 { get; set; } //PHOTO8
        public String Photo9 { get; set; } //PHOTO9
        public String Photo10 { get; set; } //PHOTO10
        public String Photo11 { get; set; } //PHOTO11
        public String Photo12 { get; set; } //PHOTO12
        public String Photo13 { get; set; } //PHOTO13
        public String Photo14 { get; set; } //PHOTO14
        public String Photo15 { get; set; } //PHOTO15
        public String Photo16 { get; set; } //PHOTO16
        public String Photo17 { get; set; } //PHOTO17
        public String Photo18 { get; set; } //PHOTO18
        public String Photo19 { get; set; } //PHOTO19
        public String Photo20 { get; set; } //PHOTO20
        public String RentOfFurniture { get; set; } //ISFURNISHED
        public String JointLease { get; set; } //CONDONB
        public String AnnualFee { get; set; } // CONDOCHARGES
        public String IndefiniteJointOwnership { get; set; } //CONDOUNDER
        public String Null100 { get; set; } //Null100
        public String Null101 { get; set; } //Null101
        public String Null102 { get; set; } //Null102
        public String Null103 { get; set; } //Null103
        public String Null104 { get; set; } //Null104
        public String Null105 { get; set; } //Null105
        public String Null106 { get; set; } //Null106
        public String Null107 { get; set; } //Null107
        public String Null108 { get; set; } //Null108
        public String Null109 { get; set; } //Null109
        public String Null110 { get; set; } //Null110
        public String Null111 { get; set; } //Null111
        public String Null112 { get; set; } //Null112
        public String Null113 { get; set; } //Null113
        public String Null114 { get; set; } //Null114
        public String Null115 { get; set; } //Null115
        public String Null116 { get; set; } //Null116
        public String Null117 { get; set; } //Null117
        public String Null118 { get; set; } //Null118
        public String Null119 { get; set; } //Null119
        public String Null120 { get; set; } //Null120
        public String Null121 { get; set; } //Null121
        public String Null122 { get; set; } //Null122
        public String Null123 { get; set; } //Null123
        public String Null124 { get; set; } //Null124
        public String Null125 { get; set; } //Null125
        public String Null126 { get; set; } //Null126
        public String Null127 { get; set; } //Null127

        public virtual Agency Agency { get; set; }
    }
}
