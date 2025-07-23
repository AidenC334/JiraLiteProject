using BugTracker.Models.Enums;
using JiraLite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public TicketPriority Priority { get; set; }

        public TicketStatus Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int ProjectId { get; set; }
        public Project? Project { get; set; }

        public string? AssignedUserId { get; set; }
        public ApplicationUser? AssignedUser { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
