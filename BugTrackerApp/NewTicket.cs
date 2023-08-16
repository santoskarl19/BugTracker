using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace BugTrackerApp
{
    public partial class NewTicket : MaterialForm
    {
        TicketRepository ticketRepository;

        public NewTicket()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void NewTicket_Load(object sender, EventArgs e)
        {
            ticketRepository = new TicketRepository();
        }

        // add ticket to database
        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {
            // display error if data field(s) are empty
            if (string.IsNullOrEmpty(txtTitle.Text) && string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Input fields cannot be empty", "Ticket creation failed");
            }
            else
            {
                // instantiate new ticket and add fields as properties
                var newTicket = new ticket();
                newTicket.Title = txtTitle.Text;
                newTicket.Description = txtDescription.Text;
                newTicket.Assignee = "Unassigned";
                newTicket.Status = "Open";

                // add ticket to repository
                ticketRepository.AddTicket(newTicket);

                MessageBox.Show("Ticket successfully created!");

                txtDescription.Clear();
                txtTitle.Clear();
            }
            
        }

        // clear data fields
        private void btnClear_TicketSubmission_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtDescription.Clear();
        }

        // return to mainpage (hide form)
        private void btnBackToLogin_Ticket_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
