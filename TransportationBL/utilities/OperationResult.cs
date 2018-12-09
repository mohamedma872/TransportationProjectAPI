using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationBL.utilities
{
  public  class OperationResult
    {

        public object Result { get; set; }
        public List<string> Exceptions { get; set; }

        public OperationResult()
        {
            Exceptions = new List<string>();
        }

    }
}
