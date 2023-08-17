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
    public partial class MainPage : MaterialForm
    {

        TicketRepository ticketRepository;
        NewTicket newTicketForm;
        public MainPage()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            CollapseMenu();
            newTicketForm = new NewTicket();
            ticketRepository = new TicketRepository();
            dataGridTickets.DataSource = ticketRepository.GetAllTickets();
            panelUpdateStatus.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        // collapse/uncollapse sidebar
        private void CollapseMenu()
        {
            // minimize
            if (this.sidebar.Width > 200)
            {
                sidebar.Width = 50;
            }

            // maximize
            else
            {
                sidebar.Width = 492;
            }
        }

        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            newTicketForm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridTickets.DataSource = ticketRepository.GetAllTickets();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var title = dataGridTickets.CurrentRow.Cells[0].Value as string;
            var ticketToDisplay = ticketRepository.GetTicket(title);

            comboBoxAssigne.Text = ticketToDisplay.Assignee;
            txtStatusUpdate.Text = ticketToDisplay.Status;
            txtTitle.Text = ticketToDisplay.Title;

            txtTitle.Enabled = false;

            panelUpdateStatus.Show();
        }
    }
}
