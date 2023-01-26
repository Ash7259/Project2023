using Project2023.Shared.Domain;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Project2023.Server.IRepository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int id);

        IEnumerable<Category> GetCategoriesByType(string type);
        IEnumerable<Category> SearchCategoriesByName(string name);
        IEnumerable<Category> GetCategoriesByTag(string tag);

        Task<Category> GetCategory(int id);
    }
}