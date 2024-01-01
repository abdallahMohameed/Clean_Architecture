using cleanArchitecture.Core.Entities;
using cleanArchitecture.Core.Interfaces;

namespace cleanArchitecture.Services.services
{
    public class CarServices : ICarServices
    {
        private readonly IRepository<Car> _carRepository;
        public CarServices(IRepository<Car> repository)
        {
            _carRepository = repository;
            
        }
        public async ValueTask<Car> create(Car car)
        {
            return await _carRepository.CreateAsync(car);
        }
    }
}
