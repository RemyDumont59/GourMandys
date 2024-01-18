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
            return await _dbContext.Cakes.Include(c => c.PicturePath).Include(cf => cf.CakeFlavors).FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Cake?> Get(Expression<Func<Cake, bool>> predicate)
        {
            return await _dbContext.Cakes.Include(c => c.PicturePath).Include(cf => cf.CakeFlavors).FirstOrDefaultAsync(predicate);
        }
        public async Task<List<Cake>> GetAll()
        {
            return await _dbContext.Cakes.Include(c => c.PicturePath).Include(cf => cf.CakeFlavors).ToListAsync();
        }
        public async Task<List<Cake>> GetAll(Expression<Func<Cake, bool>> predicate)
        {
            return await _dbContext.Cakes.Include(c => c.PicturePath).Include(cf => cf.CakeFlavors).Where(predicate).ToListAsync();
        }   
        public async Task<int> Add(Cake cake)
        {
            _dbContext.Cakes.Add(cake);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
