using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillGeneration
{
    // You must define CommodityCategory in the correct scope.
    // If CommodityCategory is meant to be a nested type inside Definition, you need to show its definition.
    // If it's a top-level type, just use CommodityCategory directly.
    // For now, I'll assume it's a top-level type. If not, please provide its definition.

    class Commodity : Definition
    {
        #region Properties  
        public CommodityCategory Category { get; set; }
        public string CommodityName { get; set; }
        public int CommodityQuantity { get; set; }
        public double CommodityPrice { get; set; }
        #endregion

        #region Constructor

        public Commodity(CommodityCategory category, string commodityName, int commodityQuatity, double commodityPrice)
        {
            
            Category = category;
            CommodityName = commodityName;
            CommodityQuantity = commodityQuatity;
            CommodityPrice = commodityPrice;
            
        }
        #endregion



    }
}
