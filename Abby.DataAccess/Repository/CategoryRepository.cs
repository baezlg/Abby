using Abby.DataAccess.Repository.IRepository;
using AbbyWeb.DataAccess.Data;
using AbbyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            //_db = db;
        }

        public void Save()
        {
            _db.SaveChanges();  
        }

        public void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(c => c.Id == category.Id);    
            objFromDb.Name = category.Name; 
            objFromDb.DisplayOrder = category.DisplayOrder;
        }
    }
}
