using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGD_BaiThucHanh3.exception
{
    internal class FractionException : Exception
    {
        public FractionException() { }

        public FractionException(string msg) : base(msg) { }
    }
}
