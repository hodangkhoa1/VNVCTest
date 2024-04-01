using VNVC_DAL.Models;
using VNVC_DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace VNVC_DAL.Repositories.Implements
{
    public class LotteryResultsRepository : IRepository<LotteryResults>
    {
        public async Task<bool> ActionEdit(LotteryResults entity, string action)
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

        public async Task<int> Count(LotteryResults? entity, string? action, string? searchAllField = null)
        {
            using var _dbContext = new VNVCContext();
            int result = 0;

            switch (action)
            {
                case "All":
                    result = await _dbContext.LotteryResults.CountAsync();
                    break;
            }

            return result;
        }

        public async Task<LotteryResults> Get(LotteryResults entity, string action)
        {
            using var _dbContext = new VNVCContext();
            LotteryResults result = new();

            switch (action)
            {
                case "GetByID":
                    result = await _dbContext.LotteryResults.Where(cr => cr.LotteryResultsID.Equals(entity.LotteryResultsID)).FirstOrDefaultAsync();
                    break;
            }

            return result;
        }

        public async Task<List<LotteryResults>> GetAll(LotteryResults entity, string action, int currentPage, int pageSize, string? searchAllField = null)
        {
            using var _dbContext = new VNVCContext();
            List<LotteryResults> result = [];

            switch (action)
            {
                case "GetAll":
                    result = await _dbContext.LotteryResults.ToListAsync();
                    break;
            }

            return result;
        }
    }
}
