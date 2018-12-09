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
        public OperationResult updateAttachments(long UserID, int key,string ImageURL)
        {
            var be = new BusinessException();
            OperationResult or = new OperationResult();
            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var result = db.Query<int>("[dbo].[updateAttachments]",
                        new
                        {
                            UserId = UserID,
                            key = key,
                            ImageURL = ImageURL
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

        public OperationResult InsertNewDriver(int userId)
        {
            var be = new BusinessException();
            OperationResult or = new OperationResult();
            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var result = db.Query<int>("Mob_CreateNewDriver",
                        new
                        {
                        UserId = userId
                          
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

        public OperationResult GetDriverProfile(int userId)
        {
            var be = new BusinessException();
            OperationResult or = new OperationResult();
            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var result = db.Query<DriverModel>("Mob_GetDriverProfileDataById",
                        new
                        {
                            UserId = userId,

                        },
                        commandType: CommandType.StoredProcedure).SingleOrDefault();
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


        public OperationResult GetDriverAttachments(int userId)
        {
            var be = new BusinessException();
            OperationResult or = new OperationResult();
            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var result = db.Query<AttchementsModel>("Mob_GetDriverAttachements",
                                new
                                    {
                                      UserId = userId
                                    }
                          , commandType: CommandType.StoredProcedure).SingleOrDefault();
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
