using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TransportationBL.BL;
using TransportationBL.Model;
using TransportationBL.Shared;
using TransportationBL.utilities;
using TransportationProjectAPI.Filter;

namespace TransportationProjectAPI.Controllers
{
    [CustomExceptionFilter]
    public class DriverController : ApiController
    {
       
        [HttpPost, Route("api/Driver/InsertVehicleData")]
      
        public OperationResult InsertVehicleData(VehcielModel model)
        {
            OperationResult or;
            try
            {
                or =new DriverBl().InsertNewVehicle(model);

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;


        }
    }
}
