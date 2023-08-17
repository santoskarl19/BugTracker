using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp
{
    interface TicketFunction
    {
        ICollection<ticket> GetAllTickets();
        ticket GetTicket(string title);
        void AddTicket(ticket ticket);
        void UpdateInfo(ticket ticket);

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

        public ticket GetTicket(string title)
        {
            return ticketsEntities.tickets.Find(title);
        }

        public ICollection<ticket> GetAllTickets()
        {
            return ticketsEntities.tickets.ToList();
        }

        public void UpdateInfo(ticket ticket)
        {
            var ticketToUpdate = ticketsEntities.tickets.Find(ticket);

            ticketToUpdate.Assignee = ticket.Assignee;
            ticketToUpdate.Status = ticket.Status;

            ticketsEntities.SaveChanges();
        }
    }
}
