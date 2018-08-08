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


        [HttpPost, Route("api/Vehicle/InsertVehicleData")]
        public OperationResult InsertVehicleData(InsertVehcielModel model)
        {
            OperationResult or;
            try
            {
                or = new VehicelBl().InsertNewVehicle(model);

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;


        }

        [HttpPost, Route("api/Vehicle/UpdateVehicleData")]
        public OperationResult UpdateVehicleData(VehcielModel vehciel)
        {
            OperationResult or;
            try
            {
                or = new VehicelBl().UpdateVehicleData(vehciel);

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;
        }


        [HttpGet, Route("api/Vehicle/GetAllVehicleCategory")]
        public OperationResult GetAllVehicleCategory()
        {
            OperationResult or;
            try
            {
                or = new VehicelBl().GetAllVehicleCategory();

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;


        }


        [HttpGet, Route("api/Vehicle/GetVehicleData")]
        public VehcielModel GetVehicleData(string lang,int userId)
        {
            //OperationResult or;
            try
            {
                var data = new VehicelBl().GetVehicleData(userId,lang);
                return data;

            }
            catch (Exception ex)
            {
                throw ex;

            }


        }

        [HttpGet, Route("api/Vehicle/GetVehicleCategoryType")]
        public OperationResult GetVehicleCategoryType(string lang)
        {
            OperationResult or;
            try
            {
                or = new VehicelBl().GetVehicleCategoryType(lang);

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;
        }
        [HttpGet, Route("api/Vehicle/GetVehicleCategoryByType")]
        public OperationResult GetVehicleCategoryByType(int typeId,string lang)
        {
            OperationResult or;
            try
            {
                or = new VehicelBl().GetVehicleCategoryByType(typeId,lang);

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;


        }
        [HttpGet, Route("api/Vehicle/GetVehicleModel")]
        public OperationResult GetVehicleModel(string lang)
        {
            OperationResult or;
            try
            {
                or = new VehicelBl().GetVehicleModel(lang);

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return or;


        }





    }
}
