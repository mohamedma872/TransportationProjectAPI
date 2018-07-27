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

        [HttpPost, Route("api/Driver/GetDriverProfile")]

        public OperationResult GetDriverProfile(int id)
        {
            OperationResult or;
            try
            {
                or = new DriverBl().GetDriverProfile(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return or;
        }

        [HttpGet, Route("api/Driver/InsertNewDriver")]
        public OperationResult InsertNewDriver(int userId,string name)
        {
            OperationResult or;
            try
            {
                or = new DriverBl().InsertNewDriver(userId,name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return or;
        }

    }
}
