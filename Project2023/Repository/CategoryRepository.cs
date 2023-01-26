using Project2023.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Project2023.Server.IRepository;

namespace Project2023.Server.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            var category = _context.Categories.Find(id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetCategoriesByType(string type)
        {
            return _context.Categories.Where(c => c.Type == type).ToList();
        }

        public IEnumerable<Category> SearchCategoriesByName(string name)
        {
            return _context.Categories.Where(c => c.Name.Contains(name)).ToList();
        }

        public IEnumerable<Category> GetCategoriesByTag(string tag)
        {
            return _context.Categories.Where(c => c.Tags.Contains(tag)).ToList();
        }
    }
}
