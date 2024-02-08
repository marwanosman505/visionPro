using Microsoft.EntityFrameworkCore;
using VisionProApp.Data;
using VisionProApp.Interfaces;
using VisionProApp.Models;

namespace VisionProApp.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationDbContext _context;

        public RoomRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(Room room)
        {
            _context.Add(room);
            return Save();
        }

        public bool Delete(Room room)
        {
            _context.Remove(room);
            return Save();
        }

        public async Task<IEnumerable<Room>> GetAll()
        {
            return await _context.Rooms.ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Room room)
        {
            _context.Update(room);
            return Save();
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Rooms.CountAsync();
        }


        public async Task<IEnumerable<Room>> GetRoomsByBuilding(Building building)
        {
            return await _context.Rooms
                .Where(b => b.BuildingId == building.Id)
                .ToListAsync();
        }

        public Room? GetById(int id)
        {
            return _context.Rooms.Find(id);
        }
    }
}
