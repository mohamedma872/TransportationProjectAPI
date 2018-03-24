using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using TransportationBL.Model;
using TransportationBL.Shared;
using TransportationBL.utilities;

namespace TransportationBL.BL
{
    public class DriverBl
    {



        public OperationResult InsertNewVehicle(VehcielModel vehciel)
        {
            var be = new BusinessException();
            OperationResult or = new OperationResult();
            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var result = db.Query<int>("Mob_InsertNewVehcile",
                        new
                        {
                            DriverID = vehciel.DriverId,
                            VehicleCategoryId = vehciel.VehicleCategoryId,
                            VehicleModelId = vehciel.VehicleModelId,
                            WeightCapacity = vehciel.WeightCapacity,
                            PlatNumber = vehciel.PlatNumber,
                            ManufactureYear = vehciel.ManufactureYear,
                            InsuranceNo = vehciel.InsuranceNo
                        },
                        commandType: CommandType.StoredProcedure).SingleOrDefault();
                    db.Close();
                    if (result > 0)
                        or.Result = result;
                    else
                        or.Exceptions.Add("there is an error please try again ");
                    return or;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }
    }
}
