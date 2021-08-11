using bookieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookieAPI.Repositories.CarRepository
{
    public class CarRepository : ICarRepository
    {
        private readonly BookContext _context;

        public CarRepository(BookContext context)
        {
            _context = context;
        }
        public async Task<Car> Create(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();
            return car;
        }

        public Task Delete(string Model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Car> Get(int IdCar)
        {
            throw new NotImplementedException();
        }

        public Task Model(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
