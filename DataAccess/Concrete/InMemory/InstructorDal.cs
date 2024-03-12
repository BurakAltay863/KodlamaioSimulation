using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            Instructor ınstructor1 = new Instructor { ID = 1, Name = "Burak Altay", Description = "Mühendis" };
            _instructors.Add(ınstructor1);
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public Instructor Get(Expression<Func<Instructor, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll(Expression<Func<Instructor, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor instructor)
        {
            var instructorToUpdate = _instructors.FirstOrDefault(c => c.ID == instructor.ID);
            if (instructorToUpdate != null)
            {
                instructorToUpdate.ID = instructor.ID;
                instructorToUpdate.Name = instructor.Name;
                instructorToUpdate.Description = instructor.Description;
            }
            else
            {
                Console.WriteLine("Başarısız güncelleme");
            }
        }
    }
}
