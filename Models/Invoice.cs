namespace AirlinesSolutions.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public decimal Amount { get; set; }
        public DateTime IssueDate { get; set; }
        public bool IsPaid { get; set; }
    }
}
