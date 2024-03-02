﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICourseDal
    {
        void Add(Course course);
        void Update(Course course);
        void Delete(Course course);
        List<Course> GetList();
    }
}
