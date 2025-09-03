using CarRentalSystem.Models;

namespace CarRentalSystem.Repository
{
    public interface IRentalRepository
    {


        IEnumerable<Rental> GetAllData(int id);
        Rental RentalById(int id);
        void AddRental(Rental rental);
        void UpdateData(int id);
        void DeleteAlldata(int id);


    }
}
