﻿using Business.Dtos.Product;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Business.Abstracts
{
    public interface IProductService
    {
        Product GetById(int id);
        Task<List<ProductToListDto>> GetAll();
        Task Add(ProductToAddDto dto);
        void Update(Product product);
        void Delete(int id);
    }
}
