using JiraLite.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BugTracker.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Ticket> AssignedTickets { get; set; } = new List<Ticket>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
