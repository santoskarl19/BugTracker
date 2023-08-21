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
        void UpdateInfo(string title, ticket ticket);
        void DeleteTicket(ticket ticket);

    }
    internal class TicketRepository : TicketFunction
    {
        BugTrackerDatabase ticketsEntities;

        public TicketRepository()
        {
            ticketsEntities = new BugTrackerDatabase();
        }

        // add ticket to database
        public void AddTicket(ticket ticket)
        {
            ticketsEntities.tickets.Add(ticket);
            ticketsEntities.SaveChanges();
        }

        // find a ticket via the title
        public ticket GetTicket(string title)
        {
            return ticketsEntities.tickets.Find(title);
        }

        // get all tickets from database
        public ICollection<ticket> GetAllTickets()
        {
            return ticketsEntities.tickets.ToList();
        }

        // update the ticket info
        public void UpdateInfo(string title, ticket ticket)
        {
            var ticketToUpdate = ticketsEntities.tickets.Find(title);

            ticketToUpdate.Assignee = ticket.Assignee;
            ticketToUpdate.Status = ticket.Status;

            ticketsEntities.SaveChanges();
        }

        // delet ticket from database
        public void DeleteTicket(ticket ticket)
        {
            ticketsEntities.tickets.Remove(ticket);
            ticketsEntities.SaveChanges();
        }

        
    }
}
