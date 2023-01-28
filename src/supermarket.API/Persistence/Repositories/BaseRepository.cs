using Supermarket.API.Persistence.Contexts;

namespace supermarket.API.Persistence.Repositories
{
    // An abstract class is a class that don’t have direct instances.
    // You have to create direct classes to create the instances.
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context; 
        }
    }
}
