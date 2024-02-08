using System.ComponentModel.DataAnnotations;

namespace VisionProApp.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Client() { }
        public Client(int id) { }
    }
}
