using Microsoft.EntityFrameworkCore;
using VisionProApp.Data;
using VisionProApp.Interfaces;
using VisionProApp.Models;

namespace VisionProApp.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationDbContext _context;

        public ClientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(Client client)
        {
            _context.Add(client);
            return Save();
        }

        public bool Delete(Client client)
        {
            _context.Remove(client);
            return Save();
        }

        public Client? GetByID(int id) 
        {
            return _context.Clients.Find(id);
        }

        public async Task<IEnumerable<Client>> GetAll()
        {
            return await _context.Clients.ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Client client)
        {
            _context.Update(client);
            return Save();
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Clients.CountAsync();
        }
    }
}
