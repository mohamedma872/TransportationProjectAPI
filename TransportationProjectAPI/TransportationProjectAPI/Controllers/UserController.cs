using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TransportationBL.BL;
using TransportationBL.utilities;
using TransportationProjectAPI.Filter;

namespace TransportationProjectAPI.Controllers
{
    [CustomExceptionFilter]
    public class UserController : ApiController
    {
        [HttpGet, Route("api/User/checkphonenumber")]

        public OperationResult checkphonenumber(string phone)
        {
            OperationResult or;
            try
            {
                or = new UserBL().checkphonenumber(phone);

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;


        }
    }
}
