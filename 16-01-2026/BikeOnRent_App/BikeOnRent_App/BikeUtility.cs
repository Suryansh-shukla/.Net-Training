using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeOnRent_App
{
    internal class BikeUtility
    {
        public void AddBikeDetails(string model,string brand, int pricePerDay)
        {
            int bikeID=Program.bikeDetails.Count+1;
            Bike newBike = new Bike
            {
                Model = model,
                Brand = brand,
                PricePerDay = pricePerDay
            };
            Program.bikeDetails.Add(bikeID, newBike);
        }
        public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
        {
            return new SortedDictionary<string, List<Bike>>(
                Program.bikeDetails.Values
                .GroupBy(bike => bike.Brand)
                .ToDictionary(group => group.Key, group => group.ToList())
            );
        }
    }
}
