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

namespace TransportationProjectAPI.Controllers
{
    public class DriverController : ApiController
    {
       
        [HttpPost, Route("api/Driver/InsertVehicleData")]

        public OperationResult InsertVehicleData(VehcielModel model)
        {
            var or = new OperationResult();
            try
            {
                or.Result =new DriverBl().InsertNewVehicle(model);

            }
            catch (BusinessException ex)
            {
                or.Exceptions = ex.Exceptions;

            }

            return or;


        }
    }
}
