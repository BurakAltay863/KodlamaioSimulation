using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            Instructor ınstructor1 = new Instructor { ID=1, Name="Burak Altay", Description="Mühendis"};
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

        public List<Instructor> GetList()
        {
           return _instructors;
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
