using Microsoft.EntityFrameworkCore;
using VisionProApp.Data;
using VisionProApp.Interfaces;
using VisionProApp.Models;

namespace VisionProApp.Repository
{
    public class AssetRepository : IAssetRepository
    {
        private readonly ApplicationDbContext _context;

        public AssetRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(Asset asset)
        {
            _context.Add(asset);
            return Save();
        }

        public bool Delete(Asset asset)
        {
            _context.Remove(asset);
            return Save();
        }

        public async Task<IEnumerable<Asset>> GetAll()
        {
            return await _context.Assets.ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Asset asset)
        {
            _context.Update(asset);
            return Save();
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Assets.CountAsync();
        }
        public async Task<IEnumerable<Asset>> GetAssetsByRoom(Room room)
        {
            return await _context.Assets
                .Where(b => b.RoomId == room.Id)
                .ToListAsync();
        }
        public Asset? GetByID(int id)
        {
            return _context.Assets.Find(id);
        }
    }
}
