using System;
using System.Collections.Generic;
using System.Text;
using Repo;

namespace BusinessLayer
{

    public interface ICarBL
    {
        List<Car> GetCarDetails(List<Car> carList);
        List<Car> AddCarForServicing(Car carObj, List<Car> carList);
    }
}
