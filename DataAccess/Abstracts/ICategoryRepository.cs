﻿using Core.DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICategoryRepository : IRepository<Category>, IAsyncRepository<Category>
    {
        //Irepository generik yapı sayesinde categori türünde oto genarete ediliyorlar
        //isteğe balı ICategoryRepository'ye özel metodlar yazılabilir 
    }
}
