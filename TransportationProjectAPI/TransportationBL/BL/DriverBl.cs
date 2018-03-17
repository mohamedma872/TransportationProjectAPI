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
       
       

       public Cities GetDriverInfo()
       {
           using (IDbConnection db=new SqlConnection(TransportationConstants.Cn))
           {
               if (db.State == ConnectionState.Closed)
                   db.Open();
               var name= db.Query<Cities>("select NameAr from cities").FirstOrDefault();
               return name;



           }
       }
        
   }
}
