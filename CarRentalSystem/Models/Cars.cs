namespace CarRentalSystem.Models
{
    public class Cars
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string NumberPlate { get; set; }
        public decimal RentPerDay { get; set; }
        public bool IsAvailable { get; set; }

        public ICollection<Rental>Rentals { get; set; }
    }
}
