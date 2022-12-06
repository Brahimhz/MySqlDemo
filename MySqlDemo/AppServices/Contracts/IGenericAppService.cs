using System.Threading.Tasks;

namespace MySqlDemo.AppService
{
    public interface IGenericAppService<T, TGetResource, TSetResource>
        where T : class
    {
        Task<TGetResource> GetById(int id);
        Task<List<TGetResource>> GetAll();

        Task<TGetResource> Add(TSetResource entity);
        Task<TGetResource> Update(int id, TSetResource entity);
        Task<int> Remove(int id);
    }
}
