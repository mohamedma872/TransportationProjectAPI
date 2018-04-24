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
    public class VehicleController : ApiController
    {
        [HttpGet, Route("api/Vehicle/GetVehicleCategoryType")]

        public OperationResult GetVehicleCategoryType()
        {
            OperationResult or;
            try
            {
                or = new VehicelBl().GetVehicleCategoryType();

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;


        }
        [HttpGet, Route("api/Vehicle/GetVehicleCategoryByType")]
        public OperationResult GetVehicleCategoryByType(int typeId)
        {
            OperationResult or;
            try
            {
                or = new VehicelBl().GetVehicleCategoryByType(typeId);

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;


        }
        [HttpGet, Route("api/Vehicle/GetVehicleModel")]
        public OperationResult GetVehicleModel()
        {
            OperationResult or;
            try
            {
                or = new VehicelBl().GetVehicleModel();

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;


        }


    }
}
