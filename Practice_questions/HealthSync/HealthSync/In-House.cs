using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSync
{
    public class In_House:Consultant
    {
        public decimal MonthlyStipend { get; set; }

        public In_House(string ConsultantID,decimal monthlystipend) : base(ConsultantID)
        {
            MonthlyStipend = monthlystipend;
        }

        public override decimal CalculateGrossPayout()
        {
            return MonthlyStipend+2000+1000;
            //throw new NotImplementedException();
        }
    }
}
