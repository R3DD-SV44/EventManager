namespace EventManager.Server.Models
{
    public class User
    {
        string name { get;set; }
        string email { get;set; }
        string password { get; set;}
        string role { get; set; }
        List<Reservation> reservationHistory { get; set; }
    
    }
}
