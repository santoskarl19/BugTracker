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
using MaterialSkin;
using System.Data.SqlClient;

namespace BugTrackerApp
{
    public partial class LogInPage : MaterialForm
    {
        UserRepository userRepository;
        MainPage mainPage = new MainPage();
        CreateNewUser createNewUser = new CreateNewUser();
        ForgotPasswordPage forgotPasswordPage = new ForgotPasswordPage();

        public LogInPage()
        {
            InitializeComponent();
            //var skinManager = MaterialSkinManager.Instance;
            //SkinManager.AddFormToManage(this);
            //SkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //SkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userRepository = new UserRepository();

            //
        }

        // log in functionality
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            // verify username and password in database
            bool checkLoginInfo = userRepository.CheckLoginInfo(userName, password);

            if(!checkLoginInfo)
            {
                MessageBox.Show("Incorrect Username or Password!", "Login failed");

                txtUserName.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Login Successful!");
                mainPage.Show();

                txtUserName.Clear();
                txtPassword.Clear();
            }
        }

        // open CreateNewUser form
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            createNewUser.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            forgotPasswordPage.Show();
        }
    }
}
