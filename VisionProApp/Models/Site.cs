using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisionProApp.Models
{
    public class Site
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Client")]
        public int? ClientId { get; set; }
        public Client? Client { get; set; }
    }
}
