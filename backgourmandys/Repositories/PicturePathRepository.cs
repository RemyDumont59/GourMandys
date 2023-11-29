using backgourmandys.Datas;
using backgourmandys.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace backgourmandys.Repositories
{
    public class PicturePathRepository : IRepository<PicturePath>
    {
        private ApplicationDbContext _dbContext { get; }
        public PicturePathRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #region Read

        public async Task<PicturePath?> GetById(int id)
        {
            return await _dbContext.PicturePaths.FindAsync(id);
        }
        public async Task<PicturePath?> Get(Expression<Func<PicturePath, bool>> predicate)
        {
            return await _dbContext.PicturePaths.FirstOrDefaultAsync(predicate);
        }
        public async Task<List<PicturePath>> GetAll()
        {
            return await _dbContext.PicturePaths.ToListAsync();
        }
        public async Task<List<PicturePath>> GetAll(Expression<Func<PicturePath, bool>> predicate)
        {
            return await _dbContext.PicturePaths.Where(predicate).ToListAsync();
        }

        #endregion

        #region Create

        

        #endregion
        #region Create
        public async Task<int> Add(PicturePath picturePath)
        {
            _dbContext.PicturePaths.Add(picturePath);
            return await _dbContext.SaveChangesAsync();
        }
        #endregion
    }
}
