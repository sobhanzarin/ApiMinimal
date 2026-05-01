

using ApiMinimal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiMinimal.Controllers
{
    [Route("api/cities/{cityId}/pointofinterest")]
    [ApiController]
    public class PointsOfInterestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PointsOfInterest>>
            GetPointsOfInterest(int cityId)
        {
            var city = CityDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
                return NotFound();
            return Ok(city.PointsOfInterest);
        }
        [HttpGet("{id}")]
        public ActionResult<PointsOfInterest>
            GetPointOfInterestById(int id, int cityId)
        {
            var city = CityDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
                return NotFound();
            var point = city.PointsOfInterest.FirstOrDefault(c => c.Id == id);
            if (point == null)
                return NotFound();

            return Ok(point);
        }
    }
}
