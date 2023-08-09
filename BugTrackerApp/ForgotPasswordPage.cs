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
            cmbBoxSecQuestion_Reset.DataSource = SecurityQuestion.Questions;
            cmbBoxSecQuestion_Reset.SelectedIndex = -1;
        }

        private void btnVerify_Reset_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void btnClear_Reset_Click(object sender, EventArgs e)
        {
            txtUserName_Reset.Clear();
            cmbBoxSecQuestion_Reset.SelectedIndex = -1;
            txtSecAnswer_Reset.Clear();
        }

        private void btnBackToLogin_Reset_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
