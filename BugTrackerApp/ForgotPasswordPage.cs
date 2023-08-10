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
    public partial class ForgotPasswordPage : MaterialForm
    {
        UserRepository userRepository;
        public ForgotPasswordPage()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void ForgotPasswordPage_Load(object sender, EventArgs e)
        {
            userRepository = new UserRepository();

            cmbBoxSecQuestion_Reset.DataSource = SecurityQuestion.Questions;
            cmbBoxSecQuestion_Reset.SelectedIndex = -1;
        }

        // prompts the reset password form when user inputs valid username, question, and password
        private void btnSubmitReset_Click(object sender, EventArgs e)
        {
            string userName = txtUserName_Reset.Text;
            string securityQuestion = cmbBoxSecQuestion_Reset.Text;
            string securityPassword = txtSecAnswer_Reset.Text;
            string newPassword = txtNewPassword_Reset.Text;

            bool verifyForgotPassword = userRepository.UpdatePasswordVerification(userName, securityQuestion, securityPassword, newPassword);

            if (!verifyForgotPassword)
            {
                MessageBox.Show("Account Authentication Failed", "Bad Credentials");

                txtUserName_Reset.Clear();
                cmbBoxSecQuestion_Reset.SelectedIndex = -1;
                txtSecAnswer_Reset.Clear();
                txtNewPassword_Reset.Clear();
                txtConfirmNewPassword_Reset.Clear();
            }
            else
            {
                MessageBox.Show("Your Password Has Been Reset!");

                txtUserName_Reset.Clear();
                cmbBoxSecQuestion_Reset.SelectedIndex = -1;
                txtSecAnswer_Reset.Clear();
                txtNewPassword_Reset.Clear();
                txtConfirmNewPassword_Reset.Clear();
            }
        }

        // clears input fields
        private void btnClear_Reset_Click(object sender, EventArgs e)
        {
            txtUserName_Reset.Clear();
            cmbBoxSecQuestion_Reset.SelectedIndex = -1;
            txtSecAnswer_Reset.Clear();
        }

        // closes form
        private void btnBackToLogin_Reset_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
