namespace CNGFinder.Models
{
    public class Pump
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool CngAvailable { get; set; }
        public string CngPressure { get; set; } // Low, Moderate, High  
        public int EstimatedWaitTime { get; set; }

    }
}
