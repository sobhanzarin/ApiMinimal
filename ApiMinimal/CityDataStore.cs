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
                new CityDto() { Id = 1, Name = "Tehran",  Description= "This is My City"},
                new CityDto() { Id = 2, Name = "Tabriz",  Description= "This is My City"},
                new CityDto() { Id = 3, Name = "Ahwaz",  Description= "This is My City"},
                new CityDto() { Id = 4, Name = "Qom",  Description= "This is My City"},

            };
        }
    }
}
