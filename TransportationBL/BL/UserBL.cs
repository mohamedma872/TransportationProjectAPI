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
    public class UserBL
    {
        
        public OperationResult checkphonenumber(string phone)
        {
            var be = new BusinessException();
            OperationResult or = new OperationResult();
            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var result = db.Query("Mob_checkphonenumber",
                        new
                        {
                            PhoneNumber = phone,

                        },
                        commandType: CommandType.StoredProcedure).SingleOrDefault();
                       db.Close();

                        or.Result = result;
                   
                    return or;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }




        public OperationResult checkEmail(string email)
        {
            var be = new BusinessException();
            OperationResult or = new OperationResult();
            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var result = db.Query("Mob_checkEmail",
                        new
                        {
                        email = email,

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


        public OperationResult UpdateMobileLang(NotificationModelcs model)
        {
            var be = new BusinessException();
            OperationResult or = new OperationResult();
            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {
                    var result = db.Query<int>("Mob_UpdateMobileLang",
                        new
                        {
                            Lang = model.Lang,
                            IEMI = model.IEMI,
                            UserID = model.UserID,
                            AccessToken = model.AccessToken,
                            IOS = model.IOS

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
