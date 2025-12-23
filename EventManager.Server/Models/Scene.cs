namespace EventManager.Server.Models
{
    public class Scene
    {
        string name { get; set; }
        int capacity { get; set; }
        string[] ChargingZones { get; set; }
        string[][] SeatsDisposition { get; set; }
    }
}
