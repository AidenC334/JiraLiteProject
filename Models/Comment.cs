using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        // Foreign keys
        public int TicketId { get; set; }
        public Ticket? Ticket { get; set; }

        public string AuthorId { get; set; } = string.Empty;
        public ApplicationUser? Author { get; set; }
    }
}
