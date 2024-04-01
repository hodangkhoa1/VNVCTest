using VNVC_DAL.Models;
using VNVC_DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace VNVC_DAL.Repositories.Implements
{
    public class AccountRepository : IRepository<Account>
    {
        public async Task<bool> ActionEdit(Account entity, string action)
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

        public async Task<int> Count(Account? entity, string? action, string? searchAllField = null)
        {
            using var _dbContext = new VNVCContext();
            int result = 0;

            switch (action)
            {
                case "All":
                    result = await _dbContext.Account.CountAsync();
                    break;
                case "Search":
                    result = await _dbContext.Account.Where(t => (string.IsNullOrEmpty(searchAllField) || t.Email.Contains(searchAllField) || t.FirstName.Contains(searchAllField) || t.LastName.Contains(searchAllField) || t.FullName.Contains(searchAllField) || t.PhoneNumber.Contains(searchAllField) || t.Address.Contains(searchAllField))).CountAsync();
                    break;
            }

            return result;
        }

        public async Task<Account> Get(Account entity, string action)
        {
            using var _dbContext = new VNVCContext();
            Account result = new();

            switch (action)
            {
                case "GetByID":
                    result = await _dbContext.Account.Where(cr => cr.AccountID.Equals(entity.AccountID)).FirstOrDefaultAsync();
                    break;
                case "GetByPhoneNumber":
                    result = await _dbContext.Account.Where(cr => cr.PhoneNumber.Equals(entity.PhoneNumber)).FirstOrDefaultAsync();
                    break;
            }

            return result;
        }

        public async Task<List<Account>> GetAll(Account entity, string action, int currentPage, int pageSize, string? searchAllField = null)
        {
            using var _dbContext = new VNVCContext();
            List<Account> result = [];

            switch (action)
            {
                case "GetAll":
                    result = await _dbContext.Account.ToListAsync();
                    break;
                case "Search":
                    result = await _dbContext.Account.Where(t => (string.IsNullOrEmpty(searchAllField) || t.Email.Contains(searchAllField) || t.FirstName.Contains(searchAllField) || t.LastName.Contains(searchAllField) || t.FullName.Contains(searchAllField) || t.PhoneNumber.Contains(searchAllField) || t.Address.Contains(searchAllField))).OrderByDescending(t => t.InsertedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();
                    break;
            }

            return result;
        }
    }
}
