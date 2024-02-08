using Microsoft.EntityFrameworkCore;
using VisionProApp.Data;
using VisionProApp.Interfaces;
using VisionProApp.Models;

namespace VisionProApp.Repository
{
    public class SiteRepository : ISiteRepository
    {

        private readonly ApplicationDbContext _context;
        public SiteRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Site site)
        {
            _context.Add(site);
            return Save();
        }

        public bool Delete(Site site)
        {
            _context.Remove(site);
            return Save();
        }

        public async Task<IEnumerable<Site>> GetAll()
        {
            return await _context.Sites.ToListAsync();
        }

        public async Task<List<Building>> GetAllBuildings()
        {
            return await _context.Buildings.ToListAsync();
        }


        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Site Site)
        {
            _context.Update(Site);
            return Save();
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Sites.CountAsync();
        }

        public async Task<IEnumerable<Site>> GetSitesByClient(Client client) 
        {
            return await _context.Sites
                .Where(x => x.Client == client)
                .ToListAsync();
        }

        public Site? GetByID(int id)
        {
            return _context.Sites.Find(id);
        }
    }
}
