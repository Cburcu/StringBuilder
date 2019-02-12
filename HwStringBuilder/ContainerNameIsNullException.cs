using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwStringBuilder
{
    class ContainerNameIsNullException : Exception
    {
        public override string Message => "Container's Name Is Null!!!";
    }
}
