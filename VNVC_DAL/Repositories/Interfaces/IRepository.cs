namespace VNVC_DAL.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> Get(T entity, string action);
        Task<List<T>> GetAll(T entity, string action, int currentPage, int pageSize, string? searchAllField = null);
        Task<bool> ActionEdit(T entity, string action);
        Task<int> Count(T? entity, string? action, string? searchAllField = null);
    }
}
