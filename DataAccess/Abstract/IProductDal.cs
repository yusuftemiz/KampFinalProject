﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Dal(Data Access Layer) veya Dao ismiyle kullanılır.
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
