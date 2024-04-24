﻿using Entities;
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
        List<Product> GetAll();
        void Add(Product product);
        void Delete(int id);
    }
}