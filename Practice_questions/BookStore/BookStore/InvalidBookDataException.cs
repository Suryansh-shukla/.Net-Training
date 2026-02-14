using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class InvalidBookDataException:Exception
    {
        public InvalidBookDataException(string message):base(message)
        {
            
        }
    }
}
