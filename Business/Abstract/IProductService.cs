﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    // List<Product> bildiğimiz T
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDeatils();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult AddTransactionalTest(Product product);
    }
}
