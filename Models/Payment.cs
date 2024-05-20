namespace AirlinesSolutions.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Owner { get; set; } 
        public DateTime DateCreated { get; set; } 
        public DateTime DateEdited { get; set; }
    }
}
