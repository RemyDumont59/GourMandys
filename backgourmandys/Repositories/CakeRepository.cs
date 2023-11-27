using System.Linq.Expressions;
using backgourmandys.Datas;
using backgourmandys.Models;
using Microsoft.EntityFrameworkCore;

namespace backgourmandys.Repositories
{
    public class CakeRepository : IRepository<Cake>
    {
        private readonly ApplicationDbContext _dbContext;
        public CakeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<Cake?> GetById(int id)
        {
            return await _dbContext.Cakes.FindAsync(id);
        }
        public async Task<Cake?> Get(Expression<Func<Cake, bool>> predicate)
        {
            return await _dbContext.Cakes.FirstOrDefaultAsync(predicate);
        }
        public async Task<List<Cake>> GetAll()
        {
            return await _dbContext.Cakes.ToListAsync();
        }
        public async Task<List<Cake>> GetAll(Expression<Func<Cake, bool>> predicate)
        {
            return await _dbContext.Cakes.Where(predicate).ToListAsync();
        }
    }
}
