using ApiMinimal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiMinimal.Controllers
{
    [Route("api/cities")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<CityDto> GetCities()
        {
           var cities = CityDataStore.Current.Cities;
            return Ok(cities);
        }
        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            var cityToResult = CityDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if(cityToResult == null) 
                return NotFound();
            return Ok(cityToResult);
        }
    }
}
