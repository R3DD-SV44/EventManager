namespace EventManager.Server.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Seat ChosenSeat { get; set; }
        public string State { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}
