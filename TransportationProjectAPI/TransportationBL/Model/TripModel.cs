using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationBL.Model
{
    class TripModel
    {
        public string TripStartDateTime { get; set; }
        public string TripPrice { get; set; }
        public string pickupName { get; set; }
        public string destinationName { get; set; }
        public string TripStatusName { get; set; }

    }
}