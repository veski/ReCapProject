using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarManager
    {
        List<Car> GetAll();
        List<CarDetailDto> GetCarDetails();
    }
}
