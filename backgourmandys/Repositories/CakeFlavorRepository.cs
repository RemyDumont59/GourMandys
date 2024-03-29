﻿using backgourmandys.Datas;
using backgourmandys.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace backgourmandys.Repositories
{
    public class CakeFlavorRepository
    {

        private readonly ApplicationDbContext _dbContext;
        public CakeFlavorRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<CakeFlavor>> GetAll()
        {
            return await _dbContext.CakeFlavors.ToListAsync();
        }
        public async Task<List<CakeFlavor>> GetAll(Expression<Func<CakeFlavor, bool>> predicate)
        {
            return await _dbContext.CakeFlavors.Where(predicate).ToListAsync();
        }
    }

}

