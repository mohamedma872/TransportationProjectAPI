using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TransportationBL.BL;

namespace TransportationProjectAPI.Controllers
{
    public class RegisterController : ApiController
    {
        [HttpGet, Route("api/Register/GetData")]
        public HttpResponseMessage GetData()
        {

            return Request.CreateResponse(HttpStatusCode.OK, new DriverBl().GetDriverInfo());
        }


        [HttpGet, Route("api/Register/GetData2")]
        public HttpResponseMessage GetData2()
        {

            return Request.CreateResponse(HttpStatusCode.OK, new DriverBl().GetDriverInfo());
        }
    }
}
