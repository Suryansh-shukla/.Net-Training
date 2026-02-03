using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryRobotHazardAnalyzer
{
    public class RobotSafetyException:Exception
    {
        public RobotSafetyException(string message) : base(message)
        {
        }
    }
}
