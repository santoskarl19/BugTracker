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
        MainPageAdmin mainPage = new MainPageAdmin();
        MainPageRegularUser mainPageRegular = new MainPageRegularUser();
        CreateNewUser createNewUser = new CreateNewUser();
        ForgotPasswordPage forgotPasswordPage = new ForgotPasswordPage();

        public LogInPage()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userRepository = new UserRepository();
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
                
                // check if user has admin rights
                if (userRepository.CheckIfAdmin(userName))
                {
                    // if previous form has been closed, instantiate a new one
                    if (mainPage == null || mainPage.IsDisposed)
                    {
                        mainPage = new MainPageAdmin();
                    }

                    mainPage.Show();

                }
                else
                {
                    // if previous form has been closed, instantiate a new one
                    if (mainPageRegular == null || mainPageRegular.IsDisposed)
                    {
                        mainPageRegular = new MainPageRegularUser();
                    }

                    mainPageRegular.Show();
                }

                // clear the text fields
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

        // TODO: reset data source so new admins can log in 

    }
}
