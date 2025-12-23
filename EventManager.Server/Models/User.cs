namespace EventManager.Server.Models
{
    public class User
    {
        string Name { get;set; }
        string Email { get;set; }
        string Password { get; set;}
        string Role { get; set; }
        List<Reservation> ReservationHistory { get; set; }
    
    }
}
