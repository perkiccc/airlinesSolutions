namespace AirlinesSolutions.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public int AvailableSeats { get; set; }
        public decimal Price { get; set; }
    }
}
