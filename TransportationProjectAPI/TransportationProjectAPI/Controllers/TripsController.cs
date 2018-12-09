using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TransportationBL.BL;
using TransportationBL.Model;
using TransportationBL.utilities;
using TransportationProjectAPI.Filter;

namespace TransportationProjectAPI.Controllers
{
    public class TripsController : ApiController
    {
        [HttpGet, Route("api/Trips/GetTripsHistory")]

        public OperationResult GetTripsHistory(int id)
        {
            OperationResult or;
            try
            {
                or = new TripBL().GetTripsHistory(id);

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;


        }



        [HttpGet, Route("api/Trips/GetTripsDetail")]

        public OperationResult GetTripsDetail(int id)
        {
            OperationResult or;
            try
            {
                or = new TripBL().GetTripDetail(id);

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;


        }

        [HttpGet, Route("api/Trips/GetDriverTripsDetail")]

        public OperationResult GetDriverTripsDetail(int id)
        {
            OperationResult or;
            try
            {
                or = new TripBL().GetDriverTripDetail(id);

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;


        }


    }


}