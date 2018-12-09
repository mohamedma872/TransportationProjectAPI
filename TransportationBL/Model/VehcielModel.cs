﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationBL.Model
{
  public class VehcielModel
    {
        public int? vId { get; set; }

        public int? supvCategoryId { get; set; }
        public string supvCategoryNameAr { get; set; }
        public string supvCategoryNameEn { get; set; }
        public string supvCategoryNameOr { get; set; }


        public int? trailerId { get; set; }
        public string vcNameAr { get; set; }
        public string vcNameEn { get; set; }
        public string vcNameOr { get; set; }

        public int? vWeight { get; set; }
        public int? vModelId { get; set; }
        public string ModelNameAr { get; set; }
        public string ModelNameEn { get; set; }
        public string ModelNameOr { get; set; }
        public string operationCard { get; set; }
        public int? manufactureYear { get; set; }
        public string insuranceNumber { get; set; }
        public string platNumber { get; set; }

       public int? driverID { get; set; }
     
      
    
      

       


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
        public string NameAr { get; set; }
        public string NameEn { get; set; }

    }


}

