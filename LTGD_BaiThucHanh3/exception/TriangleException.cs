using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGD_BaiThucHanh3.exception
{
    internal class TriangleException : Exception
    {
        public TriangleException() { }

        public TriangleException(string msg) : base(msg) { }
    }
}
