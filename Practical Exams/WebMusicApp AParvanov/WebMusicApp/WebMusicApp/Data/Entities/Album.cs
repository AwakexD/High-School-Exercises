using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMusicApp.Data.Entities
{
    public class Album
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Category { get; set; }

        [Required]
        [StringLength(80, MinimumLength = 3)]
        public string Singers { get; set; }

        [Required]
        public string Picture { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 5)]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        public string? Creator { get; set; }
    }
}
