using System.ComponentModel.DataAnnotations;

namespace ITHelpDesk1.Models
{
    public class Ticket
    {
            public int Id { get; set; }

            [Required]
            [StringLength(100)]
            public string Name { get; set; }

            [Required]
            [StringLength(150)]
            public string Title { get; set; }

            [Required]
            public string Category { get; set; }

            [Required]
            public string Description { get; set; }

            public string Status { get; set; } = "Open";

            public DateTime CreatedAt { get; set; } = DateTime.Now;
        
    }
}