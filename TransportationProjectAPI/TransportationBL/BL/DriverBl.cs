using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using TransportationBL.Model;

namespace TransportationBL.BL
{
   public class DriverBl
   {
       private const string Cn = "";

       public Driver GetDriverInfo()
       {
           using (IDbConnection db=new SqlConnection(Cn))
           {
               if (db.State == ConnectionState.Closed)
                   db.Open();
                   return db.Query<Driver>("seelct * from [user]").FirstOrDefault();
              
           }
       }
        
   }
}
