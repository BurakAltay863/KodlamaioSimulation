using Business.Concrete;
using Business.Dtos.Requests;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.ComponentModel;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CourseAdd();
            //CourseDelete();
            //CourseUpdate();
            //CategoryAdd();
            //CategoryDelete();
            CourseGetAll();

        }
        //private static void CategoryAdd()
        //{
        //    CreateCategoryRequest createCategory = new CreateCategoryRequest();
        //    createCategory.Name = "C";
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        //    categoryManager.Add(createCategory);
        //}
        //private static void CategoryDelete() {
        //    Category category3 = new Category { Id = 6, Name = "deneme" };
        //    Category category4 = new Category { Id = 5, Name = "deneme123" };
        //    CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        //    categoryManager.Add(category3);
        //    categoryManager.Add(category4);
        //    categoryManager.Delete(category3 );
        //    List<Category> list = categoryManager.GetList();
        //    foreach (var d in list)
        //    {
        //        Console.WriteLine("KursId: " + d.Id + " " + "KursName:" + d.Name);
        //    }
        //}
        private static void CourseGetAll()
        {
            CourseManager courseManager = new CourseManager(new EfCourseDal());
            List<Course> courses = courseManager.GetAll();
            Console.WriteLine("--------KURSLAR-------");
            foreach (var course in courses)
            {
                Console.WriteLine("Kurs ID:" + " " + course.ID + " CategoryID: " + course.CategoryId + " " + "IntructorId: " + course.IntructorId + " Name :" + course.Name + " Rate: " + course.Rate);
            }
        }
        private static void CourseAdd()
        {
            Course course1 = new Course {  CategoryId = 3, Image = "neo.png", IntructorId = 1, Name = "C#", Rate = 10 };
            Course course2 = new Course {  CategoryId = 4, Image = "mana.png", IntructorId = 2, Name = "Java", Rate = 20 };
            Course course3 = new Course {  CategoryId = 5, Image = "salt.png", IntructorId = 1, Name = "Flutter", Rate = 30 };

            CourseManager courseManager = new CourseManager(new EfCourseDal());
            courseManager.Add(course1);
            courseManager.Add(course2);
            courseManager.Add(course3);
            CourseGetAll();
        }
        private static void CourseDelete()
        {
            Course course1 = new Course { ID = 1, CategoryId = 1, Image = "neo.png", IntructorId = 1, Name = "C#", Rate = 10 };
            Course course2 = new Course { ID = 2, CategoryId = 2, Image = "mana.png", IntructorId = 2, Name = "Java", Rate = 20 };
            Course course3 = new Course { ID = 3, CategoryId = 1, Image = "salt.png", IntructorId = 1, Name = "Flutter", Rate = 30 };
            CourseManager courseManager = new CourseManager(new EfCourseDal());
            courseManager.Add(course1);
            courseManager.Add(course2);
            courseManager.Add(course3);
            courseManager.Delete(course1);
            CourseGetAll();
        }
        private static void CourseUpdate()
        {
            CourseManager courseManager = new CourseManager(new EfCourseDal());
            Course course1 = new Course { ID = 1, CategoryId = 1, Image = "neo.png", IntructorId = 1, Name = "C#", Rate = 10 };
            courseManager.Update(new Course() { ID = 1, Name = "Go", Rate = 36, Image = "Deneme.png" });
            CourseGetAll();
        }
    }
}
