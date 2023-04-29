using Ticket_parcial.Shared.Entities;

namespace Tickets_parcial.API.Data
{
    public class SeedDB
    {
        private readonly DataContext _context;

        public SeedDB(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckTicketsAsync();
            await _context.SaveChangesAsync();
        }

        private async Task CheckTicketsAsync()
        {
            if (!_context.Tickets.Any())
            {
                for (int i = 1; i <= 50000; i++)
                {
                    _context.Tickets.Add(new Ticket { Id = i.ToString(), Marked = false, Date = null, Gate = null });
                }
                await _context.SaveChangesAsync();
            }
        }
    }
}
