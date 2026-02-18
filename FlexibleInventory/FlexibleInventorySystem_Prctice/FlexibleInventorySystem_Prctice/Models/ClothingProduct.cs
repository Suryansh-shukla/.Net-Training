using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleInventorySystem_Practice.Models
{

    /// <summary>
    /// TODO: Implement clothing product class
    /// </summary>
    public class ClothingProduct : Product
    {
        // TODO: Add these properties
        // - Size (string)
        // - Color (string)
        // - Material (string)
        // - Gender (string) - "Men", "Women", "Unisex"
        // - Season (string) - "Summer", "Winter", "All-season"
        public string Size { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string Gender { get; set; }
        public string Season { get; set; }
        public string CurrentSeason = "Spring";
        /// <summary>
        /// TODO: Override GetProductDetails for clothing items
        /// </summary>
        public override string GetProductDetails()
        {
            // TODO: Return formatted string with size, color, material
            return $"Size: {Size}, Color: {Color}, Material: {Material}";
            throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Check if size is available
        /// Valid sizes: XS, S, M, L, XL, XXL
        /// </summary>
        public bool IsValidSize()
        {
            // TODO: Validate size against allowed values
            if (Size == null) return false;
            Size = Size.ToString();
            if(Size== "XS" || Size == "S" || Size == "M" || Size == "L" || Size == "XL" || Size == "XXL")
            {
                return true;
            }
            return false;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Override CalculateValue to apply seasonal discount
        /// Apply 15% discount for off-season items
        /// </summary>
        public override decimal CalculateValue()
        {
            // TODO: Apply seasonal discount logic
            if(!string.Equals(Season, CurrentSeason, StringComparison.OrdinalIgnoreCase))
            {
                return base.CalculateValue() * 0.85m;//Applied 15% discound for off season items
            }
            return base.CalculateValue();
            //throw new NotImplementedException();
        }
    }
}