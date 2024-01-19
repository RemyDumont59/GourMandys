using backgourmandys.Datas;
using backgourmandys.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace backgourmandys.Repositories
{
    public class FlavorRepository : IRepository<Flavor>
    {

        private readonly ApplicationDbContext _dbContext;
        public FlavorRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Flavor?> GetById(int id)
        {
            return await _dbContext.Flavors.Include(f => f.Cakes).FirstOrDefaultAsync(f => f.Id == id);
        }
        public async Task<Flavor?> Get(Expression<Func<Flavor, bool>> predicate)
        {
            return await _dbContext.Flavors.Include(f => f.Cakes).FirstOrDefaultAsync(predicate);
        }
        public async Task<List<Flavor>> GetAll()
        {
            return await _dbContext.Flavors.Include(f => f.Cakes).ToListAsync();
        }
        public async Task<List<Flavor>> GetAll(Expression<Func<Flavor, bool>> predicate)
        {
            return await _dbContext.Flavors.Include(f => f.Cakes).Where(predicate).ToListAsync();
        }
        public async Task<int> Add(Flavor flavor)
        {
            _dbContext.Flavors.Add(flavor);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
