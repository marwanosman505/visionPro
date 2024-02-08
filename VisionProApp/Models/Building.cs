using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisionProApp.Models
{
    public class Building
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Building() { }
        public Building(int id) { }
        [ForeignKey("Site")]
        public int? SiteId { get; set; }
        public Site? Site { get; set; }
    }
}
