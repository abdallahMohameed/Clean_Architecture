using cleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanArchitecture.Core.Interfaces
{
    public interface ICarServices
    {
        ValueTask<Car> create(Car car);
    }
}
