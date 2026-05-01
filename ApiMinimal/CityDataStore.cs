using ApiMinimal.Models;

namespace ApiMinimal
{
    public class CityDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CityDataStore Current { get; } = new CityDataStore();
        public CityDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto() { Id = 1, Name = "Tehran",  Description= "This is My City"
                , PointsOfInterest = new List<PointsOfInterest>()
                {
                    new PointsOfInterest() {Id = 1, Name = "Jaeyh Didanie 1", Description ="This is My Jaeyh Didanie 1"},
                    new PointsOfInterest() {Id = 2, Name = "Jaeyh Didanie 2", Description ="This is My Jaeyh Didanie 2"}
                }
                },
                new CityDto() { Id = 2, Name = "Tabriz",  Description= "This is My City",
                PointsOfInterest = new List<PointsOfInterest>()
                {
                    new PointsOfInterest() {Id = 3, Name = "Jaeyh Didanie 3", Description ="This is My Jaeyh Didanie 3" },
                    new PointsOfInterest() {Id = 4, Name = "Jaeyh Didanie 4", Description ="This is My Jaeyh Didanie 4" },
                }
                },
                new CityDto() { Id = 3, Name = "Ahwaz",  Description= "This is My City"
                ,   PointsOfInterest = new List<PointsOfInterest>()
                {
                    new PointsOfInterest() {Id = 5, Name = "Jaeyh Didanie 5", Description ="This is My Jaeyh Didanie 5" },
                    new PointsOfInterest() {Id = 6, Name = "Jaeyh Didanie 6", Description ="This is My Jaeyh Didanie 6" },
                }},
                new CityDto() { Id = 4, Name = "Qom",  Description= "This is My City"},

            };
        }
    }
}
