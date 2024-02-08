using Microsoft.EntityFrameworkCore;
using VisionProApp.Data;
using VisionProApp.Interfaces;
using VisionProApp.Models;

namespace VisionProApp.Repository
{
    public class BuildingRepository : IBuildingRepository
    {
        private readonly ApplicationDbContext _context;

        public BuildingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(Building building)
        {
            _context.Add(building);
            return Save();
        }

        public bool Delete(Building building)
        {
            _context.Remove(building);
            return Save();
        }

        public async Task<IEnumerable<Building>> GetAll()
        {
            return await _context.Buildings.ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Building building)
        {
            _context.Update(building);
            return Save();
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Buildings.CountAsync();
        }

        public Building? GetByID(int id)
        {
            return _context.Buildings.Find(id);
        }
        public async Task<IEnumerable<Building>> GetBuildingsBySite(Site site)
        {
            return await _context.Buildings
                .Where(x => x.Site == site)
                .ToListAsync();
        }
    }
}
