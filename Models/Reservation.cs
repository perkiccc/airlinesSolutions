namespace AirlinesSolutions.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string FlightClass { get; set; }
        public int NumberOfPassengers { get; set; }
        public bool IsOneWay { get; set; }
        public string BaggageInfo { get; set; }
        public DateTime FlightDate { get; set; }
        public bool IsSuccessful { get; set; }
        public decimal Price { get; set; }
    }
}
