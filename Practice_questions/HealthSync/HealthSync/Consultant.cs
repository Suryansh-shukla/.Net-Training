using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HealthSync
{
    public abstract class Consultant
    {
        public string ConsultantID { get; set; }
        protected Consultant(string ConsultantID)
        {
            
            if(!ValidateConsultantID(ConsultantID))
            {
                throw new ArgumentException("Invalid doctor id");
            }
            this.ConsultantID = ConsultantID;
        }
        public bool ValidateConsultantID(string ID)
        {
            if (string.IsNullOrEmpty(ID))
            {
                throw new ArgumentException("Invalid doctor id");
            }
            if (ID.Length!= 6)
            {
                return false;
            }
            else
            {
                string pattern = @"^[D]{1}[R]{1}[0-9]{4}$";
                if(!Regex.IsMatch(ID,pattern))
                {
                    return false; 
                }
            }
            return true;
        }
        public abstract decimal CalculateGrossPayout();
        public virtual decimal CalculateTDS(decimal gross)
        {
            if(gross<5000)
            {
                return 0.05m;
            }
            else
            {
                return 0.15m;
            }
        }
        public void ProcessPayment()
        {
            decimal gross = CalculateGrossPayout();
            decimal tds = CalculateTDS(gross);
            decimal net = gross - (gross * tds);
            Console.WriteLine("Gross: " + gross+" | TDS Applied: " + tds*100+"%"+" | Net Payout: " + net);
        }
    }
}
