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
        //
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

     
    }
}
