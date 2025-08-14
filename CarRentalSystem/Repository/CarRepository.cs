
using CarRentalSystem.DatabaseContext;
using CarRentalSystem.Models;

namespace CarRentalSystem.Repository
{
    public class CarRepository : ICarRepository

    {
        public readonly ApplicationDbContext _context;

        public CarRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Cars car)
        {
            _context.Set<Cars>().Add(car);
            _context.SaveChanges();
        }

        public string Delete(int id)
        {
            var data = _context.Set<Cars>().Find(id);
            if (data == null)
            {

                
                return "";
            }
            _context.Set<Cars>().Remove(data);
            _context.SaveChanges();
            return "";
        }

        public IEnumerable<Cars> GetAllData()
        {
            var data = _context.Set<Cars>().ToList();
            return data;
        }

        public Cars GetId(int id)
        {
            var data = _context.Set<Cars>().Find(id);
            if (data == null)
            {
                return null;
            }
            return data;

        }

        public void Update(Cars car)
        {
            _context.Set<Cars>().Find(car.Id);
            _context.SaveChanges();
        }
    }
}
