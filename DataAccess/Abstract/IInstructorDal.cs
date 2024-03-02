using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(Instructor instructor);
        List<Instructor> GetList();
    }
}
