using Microsoft.EntityFrameworkCore;
using supermarket.API.Domain.Models;
using supermarket.API.Domain.Repositories;
using Supermarket.API.Persistence.Contexts;

namespace supermarket.API.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            // the extension method ToListAsync is responsible for transforming the result of a query into a collection of categories.
            // The EF Core translates our method call to a SQL query,
            return await _context.Categories.ToListAsync();
        }
    }
}
