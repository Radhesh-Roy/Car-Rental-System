namespace CarRentalSystem.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal Fine { get; set; }
        public Customer Customers { get; set; }
        public Cars Cars { get; set; }
    }
}
