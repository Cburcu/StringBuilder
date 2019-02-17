using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwStringBuilder.Exceptions
{
    class ContainerNameIsNullException 
        : Exception
    {
        public override string Message => "Container's Name Is Null!!!";
    }
}
