using global::VisionProApp.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using VisionProApp.Models;

namespace VisionProApp.Interfaces
{   
    public interface ISiteRepository
    {
        Task<IEnumerable<Site>> GetAll();

        bool Add(Site site);

        bool Update(Site site);

        bool Delete(Site site);

        bool Save();

        Task<int> GetCountAsync();

        Task<List<Building>> GetAllBuildings();
        Task<IEnumerable<Site>> GetSitesByClient(Client client);
        Site? GetByID(int id);
    }
}
