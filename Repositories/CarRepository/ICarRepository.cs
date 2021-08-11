using bookieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookieAPI.Repositories.CarRepository
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> Get();

        Task<Car> Get(int IdCar);

        Task<Car> Create(Car car);

        Task Model(Car car);
        Task Delete(string Model);

    }
}
