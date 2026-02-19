using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexibleInventorySystem_Practice.Models;

namespace FlexibleInventorySystem_Practice.Utilities
{

    /// <summary>
    /// TODO: Implement validation helper class
    /// </summary>
    public static class ProductValidator
    {
        /// <summary>
        /// TODO: Validate product data
        /// Check:
        /// - ID not null/empty
        /// - Name not null/empty
        /// - Price > 0
        /// - Quantity >= 0
        /// </summary>
        public static bool ValidateProduct(Product product, out string? errorMessage)
        {
            // TODO: Implement validation
            errorMessage = null;
            if (product == null)
            {
                errorMessage = "product cannot be null";
                return false;
            }
            if (string.IsNullOrWhiteSpace(product.Name))
            {
                errorMessage = "product name cannot be empty";
                return false;
            }
            if (string.IsNullOrWhiteSpace(product.Id))
            {
                errorMessage = "product ID cannot be empty";
                return false;
            }
            if (product.Price <= 0)
            {
                errorMessage = "product price must be greater than 0";
                return false;
            }
            if (product.Quantity < 0)
            {
                errorMessage = "product quantity cannot be negative";
                return false;
            }
            return true;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Validate electronic product specific rules
        /// </summary>
        public static bool ValidateElectronicProduct(ElectronicProduct product, out string? errorMessage)
        {
            // TODO: Implement electronic validation
            errorMessage = null;
            if (product == null)
            {
                errorMessage = "Product cannot be null";
                return false;
            }
            if (product.WarrantyMonths < 0)
            {
                errorMessage = "Warranty months cannot be negative";
                return false;
            }
            if (string.IsNullOrWhiteSpace(product.Brand))
            {
                errorMessage = "Brand cannot be empty";
                return false;
            }
            if (string.IsNullOrWhiteSpace(product.Voltage))
            {

                errorMessage = "Voltage cannot be empty";
                return false;

            }
            return true;

            //throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Validate grocery product specific rules
        /// </summary>
        public static bool ValidateGroceryProduct(GroceryProduct product, out string? errorMessage)
        {
            // TODO: Implement grocery validation
            errorMessage = null;
            if (product == null)
            {
                errorMessage = "Product cannot be null";
                return false;
            }
            if (product.ExpiryDate < DateTime.Now)
            {
                errorMessage = "Product is expired";
                return false;
            }
            if (product.Weight <= 0)
            {
                errorMessage = "Weight must be greater than 0";
                return false;
            }
            return true;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Validate clothing product specific rules
        /// </summary>
        public static bool ValidateClothingProduct(ClothingProduct product, out string? errorMessage)
        {
            // TODO: Implement clothing validation
            errorMessage = null;
            if (product == null)
            {
                errorMessage = "Product cannot be null";
                return false;
            }
            if (product.IsValidSize() == false || string.IsNullOrWhiteSpace(product.Size))
            {
                errorMessage = "Invalid size or No Size Selected";
                return false;
            }

            if (string.IsNullOrWhiteSpace(product.Color))
            {
                errorMessage = "Color cannot be null";
                return false;
            }
            if (string.IsNullOrWhiteSpace(product.Material))
            {
                errorMessage = "Material cannot be null";
                return false;
            }
            return true;
            //throw new NotImplementedException();
        }
    }
}