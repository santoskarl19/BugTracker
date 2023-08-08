using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace BugTrackerApp
{
   
    public partial class CreateNewUser : MaterialForm
    {
        UserRepository userRepository;
        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void CreateNewUser_Load(object sender, EventArgs e)
        {
            var skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            userRepository = new UserRepository();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // function to clear all input fields
        private void ClearFields()
        {
            txtUserName_CNU.Clear();
            txtPassword_CNU.Clear();
            txtConfirmPassword_CNU.Clear();
            txtFirstName_CNU.Clear();
            txtLastName_CNU.Clear();
        }

        // clear data fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // display error when username field is empty
            if (string.IsNullOrEmpty(txtUserName_CNU.Text) && string.IsNullOrEmpty(txtPassword_CNU.Text) &&
                string.IsNullOrEmpty(txtFirstName_CNU.Text) && string.IsNullOrEmpty(txtLastName_CNU.Text))
            {
                MessageBox.Show("Input fields cannot be empty", "Account creation failed");
            }
            
            // new account creation
            if (!string.IsNullOrEmpty(txtUserName_CNU.Text) && !string.IsNullOrEmpty(txtPassword_CNU.Text) &&
                !string.IsNullOrEmpty(txtFirstName_CNU.Text) && !string.IsNullOrEmpty(txtLastName_CNU.Text) &&
                txtPassword_CNU.Text == txtConfirmPassword_CNU.Text && !string.IsNullOrEmpty(txtPassword_CNU.Text))
            {
                // instantiate new user and add fields as properties
                var user = new Developer();
                user.UserName = txtUserName_CNU.Text;
                user.Password = txtPassword_CNU.Text;
                user.FirstName = txtFirstName_CNU.Text;
                user.LastName = txtLastName_CNU.Text;

                // add user to repository
                userRepository.AddUser(user);

                MessageBox.Show("Account successfully created!");

                ClearFields();
            }

            // if passwords do not match
            else if (!string.IsNullOrEmpty(txtUserName_CNU.Text) && !string.IsNullOrEmpty(txtPassword_CNU.Text) &&
                !string.IsNullOrEmpty(txtFirstName_CNU.Text) && !string.IsNullOrEmpty(txtLastName_CNU.Text) &&
                txtPassword_CNU.Text != txtConfirmPassword_CNU.Text && !string.IsNullOrEmpty(txtPassword_CNU.Text))
            {
                MessageBox.Show("Passwords do not match", "Account creation failed");

                txtPassword_CNU.Clear();
                txtConfirmPassword_CNU.Clear();
            }
        }
    }
}
