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
    public class CustomerController : ApiController
    {
        [HttpGet, Route("api/Customer/GetCustomerProfile")]
     
        public OperationResult GetCustomerProfile(int id)
        {
            OperationResult or;
            try
            {
                or = new CustomerBl().GetCustomerProfile(id);

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;


        }
    }
}
