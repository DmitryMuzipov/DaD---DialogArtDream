using System.ComponentModel.DataAnnotations;

namespace DaD___DialogArtDream.Models
{
    public class TestModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
