using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSync
{
    public class Visiting:Consultant
    {
        public int ConsultationCount {  get; set; }
        public decimal RatePerVisit { get; set; }
        public Visiting(decimal ratepervisit,int visits,string ID) : base(ID)
        {
            ConsultationCount=visits;
            RatePerVisit = ratepervisit;
        }
        public override decimal CalculateGrossPayout()
        {
            return RatePerVisit*ConsultationCount;
            //throw new NotImplementedException();
        }
        public override decimal CalculateTDS(decimal gross)
        {
            return 0.1m;
        }
        
    }
}
