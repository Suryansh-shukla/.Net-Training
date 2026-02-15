using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidPriceException:CustomBaseException
    {
        public InvalidPriceException(string message):base(message)
        {
            
        }
    }
}
