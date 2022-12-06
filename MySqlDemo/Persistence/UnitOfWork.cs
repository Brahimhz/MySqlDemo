using System.Threading.Tasks;

namespace MySqlDemo.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private CarDbContext context;

        public UnitOfWork(CarDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
