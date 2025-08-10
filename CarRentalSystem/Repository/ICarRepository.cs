using CarRentalSystem.Models;

namespace CarRentalSystem.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Cars> GetAllData();
        Cars GetId(int id);
        void Add(Cars car);
        void Update(Cars car);
        void Delete(int id);

    }
}
