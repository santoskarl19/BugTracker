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
    public partial class ManageUsers : MaterialForm
    {
        Users users;
        AdminRightsOptions options;
        public ManageUsers()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            users = new Users();
            options = new AdminRightsOptions();

            // combo box for active users
            var activeUsers = users.GetAllUsers();
            comboBoxActiveUsers.DataSource = activeUsers;
            comboBoxActiveUsers.SelectedIndex = -1;

            // combo box for admin rights
            comboBoxAdminRights.DataSource = AdminRightsOptions.Options;
            comboBoxAdminRights.SelectedIndex = -1;
        }

        private void btnUpdateAdminRights_Click(object sender, EventArgs e)
        {

        }
    }
}
