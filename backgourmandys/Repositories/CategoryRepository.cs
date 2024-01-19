using backgourmandys.Datas;
using backgourmandys.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace backgourmandys.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Category?> GetById(int id)
        {
            return await _dbContext.Categories.Include(f => f.Cakes).FirstOrDefaultAsync(f => f.Id == id);
        }
        public async Task<Category?> Get(Expression<Func<Category, bool>> predicate)
        {
            return await _dbContext.Categories.Include(f => f.Cakes).FirstOrDefaultAsync(predicate);
        }
        public async Task<List<Category>> GetAll()
        {
            return await _dbContext.Categories.Include(f => f.Cakes).ToListAsync();
        }
        public async Task<List<Category>> GetAll(Expression<Func<Category, bool>> predicate)
        {
            return await _dbContext.Categories.Include(f => f.Cakes).Where(predicate).ToListAsync();
        }
        public async Task<int> Add(Category category)
        {
            _dbContext.Categories.Add(category);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
