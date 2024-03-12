using Business.Abstract;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public CreatedCategoryResponse Add(CreateCategoryRequest createCategoryRequest)
        {
            Category category = new Category();
            category.Name = createCategoryRequest.Name;
            _categoryDal.Add(category);
            Console.WriteLine(category.Name + " Adlı kurs Başarı ile eklendi");
            CreatedCategoryResponse createdCategoryResponse = new CreatedCategoryResponse();
            createdCategoryResponse.Name = createCategoryRequest.Name;
            createdCategoryResponse.Id = 1;
            return createdCategoryResponse;
        }

        public void Delete(Category category)
        {

            _categoryDal.Delete(category);
            Console.WriteLine(category.Id + "'IDli Kayıt başarı ile silindi");
        }

        public List<GetAllCategoryResponse> GetAll()
        {
            List<Category> categoryList = _categoryDal.GetAll();
            List<GetAllCategoryResponse> getAllCategoryResponses = new List<GetAllCategoryResponse>();
            foreach (var category in categoryList)
            {
                GetAllCategoryResponse getAllCategoryResponse = new GetAllCategoryResponse();
                getAllCategoryResponse.Name = category.Name;
                getAllCategoryResponse.Id = category.Id;
                getAllCategoryResponses.Add(getAllCategoryResponse);
            }
            return getAllCategoryResponses;
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
