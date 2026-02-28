using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class TicketService
    {
        private readonly List<Ticket> _tickets = new();

        public Ticket Purchase(Guid matchId, Guid userId, string sector)
        {
            var ticket = new Ticket
            {
                Id = Guid.NewGuid(),
                MatchId = matchId,
                UserId = userId,
                SectorName = sector,
                PurchaseDate = DateTime.UtcNow
            };

            _tickets.Add(ticket);
            return ticket;
        }

        public List<Ticket> GetByUser(Guid userId)
        {
            return _tickets.Where(t => t.UserId == userId).ToList();
        }
    }
}
