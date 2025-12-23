namespace EventManager.Server.Models
{
    public class Reservation
    {
        public User User { get; set; }
        public Seat ChosenSeat { get; set; }
        public string State { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}
