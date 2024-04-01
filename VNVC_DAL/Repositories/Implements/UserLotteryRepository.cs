using VNVC_DAL.Models;
using VNVC_DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace VNVC_DAL.Repositories.Implements
{
    public class UserLotteryRepository : IRepository<UserLottery>
    {
        public async Task<bool> ActionEdit(UserLottery entity, string action)
        {
            using var _dbContext = new VNVCContext();
            bool check = false;

            switch (action)
            {
                case "Edit":
                    _dbContext.Update(entity);
                    await _dbContext.SaveChangesAsync();
                    check = true;
                    break;
                case "Add":
                    await _dbContext.AddAsync(entity);
                    await _dbContext.SaveChangesAsync();
                    check = true;
                    break;
            }

            return check;
        }

        public async Task<int> Count(UserLottery? entity, string? action, string? searchAllField = null)
        {
            using var _dbContext = new VNVCContext();
            int result = 0;

            switch (action)
            {
                case "All":
                    result = await _dbContext.UserLottery.CountAsync();
                    break;
            }

            return result;
        }

        public async Task<UserLottery> Get(UserLottery entity, string action)
        {
            using var _dbContext = new VNVCContext();
            UserLottery result = new();

            switch (action)
            {
                case "GetByID":
                    result = await _dbContext.UserLottery.Where(cr => cr.UserLotteryID.Equals(entity.UserLotteryID)).FirstOrDefaultAsync();
                    break;
            }

            return result;
        }

        public async Task<List<UserLottery>> GetAll(UserLottery entity, string action, int currentPage, int pageSize, string? searchAllField = null)
        {
            using var _dbContext = new VNVCContext();
            List<UserLottery> result = [];

            switch (action)
            {
                case "GetAll":
                    result = await _dbContext.UserLottery.Where(u => u.AccountID.Equals(entity.AccountID)).ToListAsync();
                    break;
            }

            return result;
        }
    }
}
