using System.Collections.Generic;
using System.Threading.Tasks;
using VisionProApp.Models;

namespace VisionProApp.Interfaces
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> GetAll();

        bool Add(Room room);

        bool Update(Room room);

        bool Delete(Room room);

        bool Save();

        Task<int> GetCountAsync();
        Room? GetById(int id);
        Task<IEnumerable<Room>> GetRoomsByBuilding(Building building);
    }
}
