using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp
{
    interface TicketFunction
    {
        ICollection<ticket> GetTickets();
        void AddTicket(ticket ticket);

    }
    internal class TicketRepository : TicketFunction
    {
        BugTrackerDatabase ticketsEntities;

        public TicketRepository()
        {
            ticketsEntities = new BugTrackerDatabase();
        }

        public void AddTicket(ticket ticket)
        {
            ticketsEntities.tickets.Add(ticket);
            ticketsEntities.SaveChanges();
        }

        public ICollection<ticket> GetTickets()
        {
            return ticketsEntities.tickets.ToList();
        }
    }
}
