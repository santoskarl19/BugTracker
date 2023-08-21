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
    public partial class MainPageRegularUser : MaterialForm
    {
        TicketRepository ticketRepository;
        NewTicket newTicketForm;
        Users users;
        ManageUsers manageUsers;
        MainPageRegularUser mainPageRegularUser;
        public MainPageRegularUser()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MainPageRegularUser_Load(object sender, EventArgs e)
        {
            CollapseMenu();

            newTicketForm = new NewTicket();
            ticketRepository = new TicketRepository();
            users = new Users();
            manageUsers = new ManageUsers();
            mainPageRegularUser = new MainPageRegularUser();

            dataGridTickets.DataSource = ticketRepository.GetAllTickets();

            panelUpdateStatus.Hide();
        }

        // collapse/uncollapse sidebar
        private void CollapseMenu()
        {
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

        // menu button for sidepanel
        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        // new ticket submission button
        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            newTicketForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            panelUpdateStatus.Show();

            var title = dataGridTickets.CurrentRow.Cells[0].Value as string;
            var ticketToDisplay = ticketRepository.GetTicket(title);

            comboBoxAssigne2.Text = ticketToDisplay.Assignee;
            txtStatusUpdate2.Text = ticketToDisplay.Status;
            txtTitle2.Text = ticketToDisplay.Title;

            txtTitle2.Enabled = false;
            comboBoxAssigne2.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var title = dataGridTickets.CurrentRow.Cells[0].Value as string;
            var ticketToUpdate = ticketRepository.GetTicket(title);

            ticketToUpdate.Status = txtStatusUpdate2.Text;

            ticketRepository.UpdateInfo(title, ticketToUpdate);

            MessageBox.Show("Ticket has been updated!");

            txtStatusUpdate2.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridTickets.DataSource = ticketRepository.GetAllTickets();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to logout?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //this.Hide();
                this.Close();
                mainPageRegularUser = null;
            }
        }
    }
}
