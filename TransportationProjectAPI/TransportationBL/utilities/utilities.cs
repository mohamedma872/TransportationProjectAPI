using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace TransportationBL.utilities
{
    public class Utilities
    {
        public void InsertLog(string controllerName, string actionName, string errorDesc)
        {

            using (IDbConnection db = new SqlConnection(TransportationConstants.Cn))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                db.Query("LogError",
                    new
                    {
                        ControllerName = controllerName,
                        ActionName = actionName,
                        Description = errorDesc,
                        DateOfCreate = Common.GetDateOfNow()
                    }, commandType: CommandType.StoredProcedure);

                db.Close();

            }


        }
    }
}
