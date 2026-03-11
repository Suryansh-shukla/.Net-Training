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
        [Route("JoiningCities")]
        [HttpGet]
        public List<string> ShowAllCities()
        {
            return cityList;
        }
        [Route("GetCityList/{stateName}")]
        [HttpGet]
        public List<string> GetCityList(string stateName)
        {
            return cityList;
        }

        [Route("FetchAllCities/{stateID}")]
        [HttpGet]
        public List<string> fetchALlCities(int stateID)
        {
            return cityList;
        }
        [HttpGet]
        public int AddMe(int num1,int num2)
        {
            return num1 + num2;
        }
    }
}
