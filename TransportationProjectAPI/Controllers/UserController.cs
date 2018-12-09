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

        [HttpGet, Route("api/User/checkEmail")]

        public OperationResult checkEmail(string email)
        {
            OperationResult or;
            try
            {
                or = new UserBL().checkEmail(email);

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;


        }

        [HttpPost, Route("api/User/UpdateMobileLang")]

        public OperationResult UpdateMobileLang(NotificationModelcs model)
        {
            OperationResult or;
            try
            {
                or = new UserBL().UpdateMobileLang(model);

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;


        }

    }
}
