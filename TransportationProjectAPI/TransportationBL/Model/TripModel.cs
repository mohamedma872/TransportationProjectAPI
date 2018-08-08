using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationBL.Model
{
    class TripModel
    {
        //
        public string TripStartDateTime { get; set; }
        public string TripPrice { get; set; }
        public string pickupName { get; set; }
        public string destinationName { get; set; }
        public string TripStatusName { get; set; }
        public int TripId { get; set; }

    }

    class TripDetailModel
    {
        public int TripId { get; set; }
        public string TripStartDateTime { get; set; }
        public string TripPrice { get; set; }
        public decimal? PickupLatitude { get; set; }
        public decimal? PickupLongitude { get; set; }
        public decimal? DestinationLatitude { get; set; }
        public decimal? DestinationLongitude { get; set; }
        public string TripStatusName { get; set; }
        public string DriverName { get; set; }
        public string UserName { get; set; }
        public string UserPhoneNumber { get; set; }
        public string VehiclecategoryName { get; set; }
        public string PlatNumber { get; set; }
        public string Distance { get; set; }
        public string Duration { get; set; }
        public string ImageURL { get; set; }
        public string DriverPhoneNumber { get; set; }

    }
}