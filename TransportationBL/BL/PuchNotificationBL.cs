using BL.model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportationBL.Shared;
using TransportationBL.utilities;

namespace TransportationBL.BL
{
   public class PuchNotificationBL
    {
        public OperationResult UpdateLang(NotificationModel obj)
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
                            lang = obj.Lang,
                            IEMI = obj.IEMI,
                            UserID = obj.ID,
                            AccessToken =obj.AccessToken,
                            IOS =obj.IOS


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

        public OperationResult GetLangauge(NotificationModel obj)
        {


        }
    }
}
