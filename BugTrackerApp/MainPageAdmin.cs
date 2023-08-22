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
    public partial class MainPageAdmin : MaterialForm
    {

        TicketRepository ticketRepository;
        NewTicket newTicketForm;
        Users users;
        ManageUsers manageUsers;
        MainPageAdmin mainPageAdmin;
        LogInPage logInPage;
        public MainPageAdmin()
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
            users = new Users();
            manageUsers = new ManageUsers();
            mainPageAdmin = new MainPageAdmin();
            logInPage = new LogInPage();

            dataGridTickets.DataSource = ticketRepository.GetAllTickets();
            
            var listOfUsers = users.GetAllUsers();
            comboBoxAssigne.DataSource = listOfUsers;

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

        // display new ticket submission form
        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            newTicketForm.Show();
        }

        // refresh data currently displayed in the window
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridTickets.DataSource = ticketRepository.GetAllTickets();
        }

        // update selected ticket. panel will be displayed below the table
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var title = dataGridTickets.CurrentRow.Cells[0].Value as string;
            var ticketToUpdate = ticketRepository.GetTicket(title);

            ticketToUpdate.Assignee = comboBoxAssigne.Text;
            ticketToUpdate.Status = txtStatusUpdate.Text;

            ticketRepository.UpdateInfo(title, ticketToUpdate);

            MessageBox.Show("Ticket has been updated!");

            comboBoxAssigne.SelectedIndex = -1;
            txtStatusUpdate.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var title = dataGridTickets.CurrentRow.Cells[0].Value as string;
            var ticketToDelete = ticketRepository.GetTicket(title);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this ticket?", "Delete File", MessageBoxButtons.YesNo);

            if  (result == DialogResult.Yes)
            {
                ticketRepository.DeleteTicket(ticketToDelete);
                MessageBox.Show("Ticket has been deleted!");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to logout?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
                mainPageAdmin = null;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            manageUsers.Show();
        }
    }
}
