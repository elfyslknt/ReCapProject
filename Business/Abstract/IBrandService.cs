﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        Brand GetById(int id);
    }
}
