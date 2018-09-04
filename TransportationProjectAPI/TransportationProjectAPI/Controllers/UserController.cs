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

        [HttpGet, Route("api/User/checkEmailForEditProfile")]

        public OperationResult checkEmailForEditProfile(string email , int userId)
        {
            OperationResult or;
            try
            {
                or = new UserBL().checkEmailForEditProfile(email,userId);

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;


        }


    }
}
