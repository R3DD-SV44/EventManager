namespace EventManager.Server.Models
{
    public class Scene
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Capacity { get; set; }
        string[] ChargingZones { get; set; }
        string[][] SeatsDisposition { get; set; }
    }
}
