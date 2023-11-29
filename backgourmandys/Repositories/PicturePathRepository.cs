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

        #region Create

        public async Task<int> Add(PicturePath picturePath)
        {
            var addedPicturePath = await _dbContext.PicturePaths.AddAsync(picturePath);
            await _dbContext.SaveChangesAsync();
            return addedPicturePath.Entity.Id;
        }

        #endregion

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

        #region Update

        public async Task<bool> Update(PicturePath picturePath)
        {
            var picturePathFromDb = await GetById(picturePath.Id);

            if (picturePathFromDb == null) 
                return false;

            if (picturePathFromDb.Path != picturePath.Path)
                picturePathFromDb.Path = picturePath.Path;

            if (picturePathFromDb.CakeId != picturePath.CakeId)
                picturePathFromDb.CakeId = picturePath.CakeId;

            return await _dbContext.SaveChangesAsync() > 0;
        }

        #endregion

        #region Delete

        public async Task<bool> Delete(int id)
        {
            var picturePathToDelete = await GetById(id);

            if (picturePathToDelete == null) 
                return false;

            _dbContext.PicturePaths.Remove(picturePathToDelete);
            return await _dbContext.SaveChangesAsync() > 0;
        }
        #endregion
    }
}
