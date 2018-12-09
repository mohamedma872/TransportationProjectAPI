﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationBL.Model
{
  public class VehcielModel
    {
        
        public int? driverID { get; set; }
        public int? vId { get; set; }
        public int? vCategoryNameId { get; set; }
        public string vCategoryName { get; set; }
        public int? trailerTypeId { get; set; }
        public string trailerTypeName { get; set; }
        public int? vModelId { get; set; }
        public string vModelName { get; set; }
        public int? vWeight { get; set; }
        public string operationCard { get; set; }
        public int? manufactureYear { get; set; }
        public string insuranceNumber { get; set; }
        public string platNumber { get; set; }
        public string CurrentLatitude { get; set; }
        public string CurrentLongitude { get; set; }
        public string distance_in_km { get; set; }
        public string Driverphone { get; set; }
        public string DriverNameAr { get; set; }
        public string DriverNameEn { get; set; }
        public string DriverNameOr { get; set; }
        public string DriverImage { get; set; }
        public string CategoryID { get; set; }
        public string CategoryImage { get; set; }
        public string CategoryCost { get; set; }
        public string CategoryNameAR { get; set; }
        public string CategoryNameEN { get; set; }
        public string CategoryNameOR { get; set; }
        public string ModelNameAr { get; set; }
        public string ModelNameEn { get; set; }
        public string ModelNameOr { get; set; }
        public string AccessToken { get; set; }

        public string CurrentLang { get; set; }
        public string IsIOS { get; set; }
    }


    public class InsertVehcielModel
    {
        public int? VId { get; set; }
        public int? UserID { get; set; }
        public int? vCategoryNameId { get; set; }
        public int? vModelId { get; set; }
        public int? vWeight { get; set; }
        public string OperationCard { get; set; }
        public int? manufactureYear { get; set; }
        public string insuranceNumber { get; set; }
        public string platNumber { get; set; }

    }


    public class AllVehcielCategoryModel
    {
        public int? id         { get; set; }
        public string imageUrl { get; set; }
        public string nameAr   { get; set; }
        public string nameEn   { get; set; }
        public string nameOr   { get; set; }
        public int? parentId   { get; set; }

    }

 


    public class VehcielCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
      

    }


}
