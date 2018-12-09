using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationBL.Shared
{
  public  class BusinessException : Exception
    {
        public List<string> Exceptions { get; set; }

        public int ExceptionNumber { get; set; }

        public BusinessException()
            : base()
        {
            Exceptions = new List<string>();
        }

        public static Exception GetInnerException(Exception ex)
        {
            if (ex.InnerException == null)
                return ex;

            return GetInnerException(ex.InnerException);
        }

    }
}
