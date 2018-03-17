using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using TransportationBL.Model;
using TransportationBL.utilities;

namespace TransportationBL.BL
{
   public class DriverBl
   {
       
       

       public Driver GetDriverInfo()
       {
           using (IDbConnection db=new SqlConnection(TransportationConstants.Cn))
           {
               if (db.State == ConnectionState.Closed)
                   db.Open();
                   return db.Query<Driver>("seelct * from [user]").FirstOrDefault();
              
           }
       }
        
   }
}
