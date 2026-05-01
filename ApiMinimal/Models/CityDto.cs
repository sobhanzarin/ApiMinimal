namespace ApiMinimal.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? NumberOfPoints { get
            {
                return PointsOfInterest.Count;
            }
                }
        public ICollection<PointsOfInterest> PointsOfInterest { get; set; }
        = new List<PointsOfInterest>();
    }
}
