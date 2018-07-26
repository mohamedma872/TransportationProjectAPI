﻿using System;
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
        public int? priceLoadingWater { get; set; }
        public int? manufactureYear { get; set; }
        public string insuranceNumber { get; set; }
        public string platNumber { get; set; }
       
      

    }


    public class VehcielCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
      

    }


}

