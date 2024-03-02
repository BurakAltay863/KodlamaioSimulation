using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _category;

        public CategoryDal()
        {
            _category = new List<Category>();
            Category category1 = new Category { Id = 1, Name = "Yapay Zeka" };
            Category category2 = new Category { Id = 2, Name = "Veri Bilimi" };
            _category.Add(category1);
            _category.Add(category2);
        }

        public void Add(Category category)
        {
            _category.Add(category);
        }

        public void Delete(Category category)
        {
           
            _category.Remove(category);
        }

        public List<Category> GetList()
        {
            return _category;
        }

        public void Update(Category category)
        {
            var categoryToUpdate = _category.FirstOrDefault(c => c.Id == category.Id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Id = category.Id;
                categoryToUpdate.Name = category.Name;
                Console.WriteLine(categoryToUpdate.Id +"nOLU category başarı ile eklendi");
               
            }
            else { Console.WriteLine("Güncellenecek category bulunamadı"); }
        }
    }
}
