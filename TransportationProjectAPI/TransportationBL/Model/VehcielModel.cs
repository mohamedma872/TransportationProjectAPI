using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationBL.Model
{
  public class VehcielModel
    {
        public int? DriverId { get; set; }
        public int? VehicleCategoryId { get; set; }
        public int? VehicleModelId { get; set; }
        public int? WeightCapacity { get; set; }
        public string PlatNumber { get; set; }
        public int? ManufactureYear { get; set; }
        public string InsuranceNo { get; set; }

    }
}
