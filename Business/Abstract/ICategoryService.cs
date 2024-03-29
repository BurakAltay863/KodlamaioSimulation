﻿using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        CreatedCategoryResponse Add(CreateCategoryRequest createCategoryRequest);
        void Update(Category category);
        void Delete(Category category);
        List<GetAllCategoryResponse> GetAll();
    }
}
