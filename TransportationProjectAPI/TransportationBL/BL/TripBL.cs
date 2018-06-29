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
    public class TripBL
    {
        public OperationResult GetTripsHistory(int userId)
        {
            var be = new BusinessException();
            OperationResult or = new OperationResult();
            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var result = db.Query<TripModel>("Mob_GetTripsHistory",
                        new
                        {
                            UserId = userId,

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
