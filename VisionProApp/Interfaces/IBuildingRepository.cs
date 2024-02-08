using System.Collections.Generic;
using System.Threading.Tasks;
using VisionProApp.Models;

namespace VisionProApp.Interfaces
{
    public interface IBuildingRepository
    {
        Task<IEnumerable<Building>> GetAll();

        bool Add(Building building);

        bool Update(Building building);

        bool Delete(Building building);

        bool Save();

        Task<int> GetCountAsync();
        Building? GetByID(int id);
        Task<IEnumerable<Building>> GetBuildingsBySite(Site site);


    }
}
