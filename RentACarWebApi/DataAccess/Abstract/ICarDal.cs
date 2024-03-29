﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal: IEntityRepository<Car>
    {
        //ürüne ait özel operasyonlar bu kısma yazılmalıdır.

        List<CarDetailDto> GetCarDetails();
        CarDetailDto GetCarDetails(int carId);
    }
}
