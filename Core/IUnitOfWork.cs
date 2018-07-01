using System.Threading.Tasks;

namespace vegaAPI.Core
{
    public interface IUnitOfWork
    {
        Task ComplateAsync();
    }
}