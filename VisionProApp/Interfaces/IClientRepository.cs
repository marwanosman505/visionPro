using System.Collections.Generic;
using System.Threading.Tasks;
using VisionProApp.Models;

namespace VisionProApp.Interfaces
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAll();

        bool Add(Client client);

        bool Update(Client client);

        bool Delete(Client client);

        bool Save();

        Task<int> GetCountAsync();
        Client? GetByID(int id);
    }
}
