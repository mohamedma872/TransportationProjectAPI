using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using TransportationBL.Model;
using TransportationBL.Shared;
using TransportationBL.utilities;

namespace TransportationBL.BL
{
   public class CustomerBl
    {
        
        public OperationResult GetCustomerProfile(int userId)
        {
            var be = new BusinessException();
            OperationResult or = new OperationResult();
            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var result = db.Query<CustomerModel>("Mob_GetCustomerProfileDataById",
                        new
                        {
                            UserId = userId,
                           
                        },
                        commandType: CommandType.StoredProcedure).SingleOrDefault();
                    db.Close();
                    if (result != null)
                        or.Result = result;
                    else
                        or.Exceptions.Add("there is an error please try again");
                    return or;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }

    

        public OperationResult EditCustomerProfile(CustomerProfileModel model)
        {
            var be = new BusinessException();
            OperationResult or = new OperationResult();
            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var result = db.Query<int>("Mob_EditCustomerProfile",
                        new
                        {
                        UserID = model.Id,
                        FullName = model.Fullname,
                        Email = model.Email,

                        },
                        commandType: CommandType.StoredProcedure).SingleOrDefault();
                    db.Close();
                    if (result==1)
                        or.Result = result;
                    else
                        or.Exceptions.Add("there is an error please try again");
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
