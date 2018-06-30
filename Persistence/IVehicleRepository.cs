using System.Threading.Tasks;
using vegaAPI.Models;

namespace vegaAPI.Persistence
{
    public interface IVehicleRepository
    {
         Task<Vehicle> GetVehicle(int id);
    }
}