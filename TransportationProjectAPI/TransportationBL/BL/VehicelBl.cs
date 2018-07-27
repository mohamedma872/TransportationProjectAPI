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
    public class VehicelBl
    {



        public OperationResult UpdateVehicleData(VehcielModel vehciel)
        {
            var be = new BusinessException();
            OperationResult or = new OperationResult();
            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var result = db.Query<int>("Mob_EditVehicleData",
                        new
                        {
                        DriverID = vehciel.driverID,
                        VehicleCategoryId = vehciel.vCategoryNameId,
                        WeightCapacity = vehciel.vWeight,
                        VehicleModelId = vehciel.vModelId,
                        WaterLoadingPrice = vehciel.priceLoadingWater,
                        ManufactureYear = vehciel.manufactureYear,
                        InsuranceNo = vehciel.insuranceNumber,
                        PlatNumber = vehciel.platNumber
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

        public OperationResult InsertNewVehicle(InsertVehcielModel vehciel)
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
                        VId = vehciel.VId,
                        UserID = vehciel.UserID,
                        VehicleCategoryId = vehciel.vCategoryNameId,
                        WeightCapacity = vehciel.vWeight,
                        VehicleModelId = vehciel.vModelId,
                        WaterLoadingPrice = vehciel.priceLoadingWater,
                        ManufactureYear = vehciel.manufactureYear,
                        InsuranceNo = vehciel.insuranceNumber,
                        PlatNumber= vehciel.platNumber
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

        public VehcielModel GetVehicleData(int userId,string lang)
        {
            var be = new BusinessException();
           // OperationResult or = new OperationResult();
            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var result = db.Query<VehcielModel>("Mob_GetVehicleData",

                          new
                          {   userId= userId,
                              Lang = lang
                          }
                    , commandType: CommandType.StoredProcedure).FirstOrDefault();
                    db.Close();
                  
                      //  or.Result = result;
                    
                    return result;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }

        public OperationResult GetVehicleCategoryType(string lang)
        {
            var be = new BusinessException();
            OperationResult or = new OperationResult();
            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var result = db.Query<VehcielCategory>("Mob_GetVehicleCategoryType",
                                                           
                          new
                          {
                              Lang = lang
                          }
                    , commandType: CommandType.StoredProcedure).ToList();                                                          
                    db.Close();
                    if (result != null)
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


        public OperationResult GetVehicleCategoryByType(int typeId,string lang)
        {
            var be = new BusinessException();
            OperationResult or = new OperationResult();
            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var result = db.Query<VehcielCategory>("Mob_GetVehicleCategoryByType",
                          new
                            {
                               TypeId = typeId,
                               Lang = lang

                            },commandType: CommandType.StoredProcedure).ToList();
                    db.Close();
                    if (result != null)
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

        public OperationResult GetVehicleModel(string lang)
        {
            var be = new BusinessException();
            OperationResult or = new OperationResult();
            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var result = db.Query<VehcielCategory>("Mob_GetVehicleModel",
                          new
                          {
                              Lang = lang
                          },
                        commandType: CommandType.StoredProcedure).ToList();
                    db.Close();
                    if (result != null)
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
