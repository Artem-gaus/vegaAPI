using System.Threading.Tasks;

namespace vegaAPI.Persistence
{
    public interface IUnitOfWork
    {
        Task ComplateAsync();
    }
}