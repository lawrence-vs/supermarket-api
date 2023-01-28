using supermarket.API.Domain.Models;
namespace supermarket.API.Domain.Repositories

{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
