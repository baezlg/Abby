﻿using Abby.DataAccess.Repository.IRepository;
using Abby.Models;
using AbbyWeb.DataAccess.Data;
using AbbyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby.DataAccess.Repository
{
    public class MenuItemRepository : Repository<MenuItem>, IMenuItemRepository
    {
        private readonly ApplicationDbContext _db;

        public MenuItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(MenuItem obj)
        {
            var objFromDb = _db.MenuItems.FirstOrDefault(c => c.Id == obj.Id);    
            objFromDb.Name = obj.Name; 
            objFromDb.Description = obj.Description; 
            objFromDb.Price = obj.Price; 
            objFromDb.CategoryId = obj.CategoryId; 
            objFromDb.FoodTypeId = obj.FoodTypeId; 
            if(objFromDb.Image != null)
            {
                objFromDb.Image = obj.Image;
            }
        }
    }
}
