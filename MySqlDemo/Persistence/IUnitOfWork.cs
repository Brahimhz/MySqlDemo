using System.Threading.Tasks;

namespace MySqlDemo.Persistence
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
