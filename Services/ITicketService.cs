using BugTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Services
{
    public interface ITicketService
    {
        Task<List<Ticket>> GetAllAsync();
        Task<Ticket?> GetByIdAsync(int id);
        Task CreateAsync(Ticket ticket);
        Task UpdateAsync(Ticket ticket);
        Task DeleteAsync(int id);
        Task AddCommentAsync(Comment comment);


    }
}
