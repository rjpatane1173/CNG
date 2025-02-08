namespace CNGNavigator.Models.DTOs
{
    public class PumpStatusUpdateDto
    {
        public long PumpId { get; set; }
        public bool CngAvailable { get; set; }
        public string CngPressure { get; set; } // Low, Moderate, High
        public int EstimatedWaitTime { get; set; } // In minutes
    }

}
