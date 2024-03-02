using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            _courses = new List<Course>();
            Course course1 = new Course { ID = 5, CategoryId = 4, Image = "ALO.png", IntructorId = 1, Name = "MAT", Rate = 10 };
            Course course2 = new Course { ID = 6, CategoryId = 5, Image = "BELA.png", IntructorId = 2, Name = "SOSYAL", Rate = 20 };
            Course course3 = new Course { ID = 7, CategoryId = 6, Image = "KİMO.png", IntructorId = 1, Name = "FİZİK", Rate = 30 };
            _courses.Add(course1);
            _courses.Add(course2);
            _courses.Add(course3);
        }

        public void Add(Course course)
        {

           _courses.Add(course);
        }

        public void Delete(Course course)
        {
            _courses.Remove(course);
        }

      
        public List<Course> GetList()
        {
           return _courses;
        }

        public void Update(Course course)
        {
            var coursToUpdate = _courses.FirstOrDefault(c => c.ID == course.ID);
            if (coursToUpdate != null)
            {
                coursToUpdate.ID = course.ID;
                coursToUpdate.Name = course.Name;
                coursToUpdate.Image= course.Image;
                coursToUpdate.Rate = course.Rate;
                coursToUpdate.IntructorId = course.IntructorId;
                coursToUpdate.CategoryId = course.CategoryId;
                Console.WriteLine(coursToUpdate.ID +" nolu kurs güncellendi");
            }
            else
            {
               Console.WriteLine("Güncellenecek kurs bulunamadı");
            }
        }
    }
}
