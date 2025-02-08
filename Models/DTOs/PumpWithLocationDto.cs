namespace CNGNavigator.Models.DTOs
{
    public class PumpWithLocationDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool CngAvailable { get; set; }
        public string CngPressure { get; set; }
        public int EstimatedWaitTime { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
