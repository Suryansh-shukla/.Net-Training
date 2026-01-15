using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillGeneration
{
    class PrepareBill:Definition
    {
        IDictionary<CommodityCategory, double> _taxRates { get; set; }
        public PrepareBill()
        {
            _taxRates = new Dictionary<CommodityCategory, double>()
            {
                { CommodityCategory.Furniture, 0.10 },
                { CommodityCategory.Grocery, 0.05 },
                { CommodityCategory.Service, 0.15 }
            };
        }
    }
}
