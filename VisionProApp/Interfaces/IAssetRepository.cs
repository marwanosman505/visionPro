using System.Collections.Generic;
using System.Threading.Tasks;
using VisionProApp.Models;

namespace VisionProApp.Interfaces
{
    public interface IAssetRepository
    {
        Task<IEnumerable<Asset>> GetAll();

        bool Add(Asset asset);

        bool Update(Asset asset);

        bool Delete(Asset asset);

        bool Save();

        Task<int> GetCountAsync();
        Asset? GetByID(int id);
        Task<IEnumerable<Asset>> GetAssetsByRoom(Room room);

    }
}
