using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        public static List<string> cityList = null;
        public CityController()
        {
            if(cityList==null)
            {
                cityList = new List<string>()
                {
                    "Delhi",
                    "Mumbai",
                    "Chennai",
                    "Kolkata",
                    "Pune",
                    "Hyderabad"
                };
            }
        }
        [Route("Joining Cities")]
        public List<string> ShowAllCities()
        {
            return cityList;
        }
    }
}
