using api.Models;
using api.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        private readonly ICityService cityService;

        public CitiesController(ICityService cityService)
        {
            this.cityService = cityService;
        }

        [HttpGet("/{country}")]
        public IEnumerable<string> GetCities(string country)
        {
            return cityService.GetAllCities(country);
        }

        [HttpPost]
        public void Update()
        {
            var json = System.IO.File.ReadAllText("./Data/city.list.json");

            var cities = JsonConvert.DeserializeObject<List<City>>(json);

            cityService.InsertCities(cities);
            cityService.Save();
        }
    }
}