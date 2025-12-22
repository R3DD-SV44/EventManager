namespace EventManager.Server.Models
{
    public class Event
    {
        string name { get; set; }
        string date { get; set; }
        string description { get; set; }
        Scene location { get; set; }

    }
}
