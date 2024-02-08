using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisionProApp.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Building")]
        public int? BuildingId { get; set; }
        public Building? Building { get; set; }
    }
}
