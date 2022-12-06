using Microsoft.EntityFrameworkCore;

namespace MySqlDemo.Persistence.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly CarDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(CarDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();

        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }
        public void Remove(int id)
        {
            _dbSet.Remove(_dbSet.Find(id));
        }
        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
