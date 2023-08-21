namespace BugTrackerApp
{
    partial class ManageUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUserFirstName = new System.Windows.Forms.Label();
            this.lblAdminRights = new System.Windows.Forms.Label();
            this.btnBackToLogin_Ticket = new System.Windows.Forms.Button();
            this.btnClear_TicketSubmission = new System.Windows.Forms.Button();
            this.btnUpdateAdminRights = new System.Windows.Forms.Button();
            this.comboBoxActiveUsers = new System.Windows.Forms.ComboBox();
            this.comboBoxAdminRights = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblUserFirstName
            // 
            this.lblUserFirstName.AutoSize = true;
            this.lblUserFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserFirstName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserFirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFirstName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblUserFirstName.Location = new System.Drawing.Point(135, 201);
            this.lblUserFirstName.Name = "lblUserFirstName";
            this.lblUserFirstName.Size = new System.Drawing.Size(90, 38);
            this.lblUserFirstName.TabIndex = 10;
            this.lblUserFirstName.Text = "User:";
            // 
            // lblAdminRights
            // 
            this.lblAdminRights.AutoSize = true;
            this.lblAdminRights.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminRights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAdminRights.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminRights.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAdminRights.Location = new System.Drawing.Point(135, 274);
            this.lblAdminRights.Name = "lblAdminRights";
            this.lblAdminRights.Size = new System.Drawing.Size(228, 38);
            this.lblAdminRights.TabIndex = 11;
            this.lblAdminRights.Text = "Admin Rights:";
            // 
            // btnBackToLogin_Ticket
            // 
            this.btnBackToLogin_Ticket.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToLogin_Ticket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToLogin_Ticket.FlatAppearance.BorderSize = 0;
            this.btnBackToLogin_Ticket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBackToLogin_Ticket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBackToLogin_Ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToLogin_Ticket.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin_Ticket.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBackToLogin_Ticket.Location = new System.Drawing.Point(308, 520);
            this.btnBackToLogin_Ticket.Name = "btnBackToLogin_Ticket";
            this.btnBackToLogin_Ticket.Size = new System.Drawing.Size(332, 94);
            this.btnBackToLogin_Ticket.TabIndex = 30;
            this.btnBackToLogin_Ticket.Text = "Back To Login";
            this.btnBackToLogin_Ticket.UseVisualStyleBackColor = false;
            this.btnBackToLogin_Ticket.Click += new System.EventHandler(this.btnBackToLogin_Ticket_Click);
            // 
            // btnClear_TicketSubmission
            // 
            this.btnClear_TicketSubmission.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear_TicketSubmission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear_TicketSubmission.FlatAppearance.BorderSize = 0;
            this.btnClear_TicketSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear_TicketSubmission.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear_TicketSubmission.ForeColor = System.Drawing.Color.White;
            this.btnClear_TicketSubmission.Location = new System.Drawing.Point(338, 444);
            this.btnClear_TicketSubmission.Name = "btnClear_TicketSubmission";
            this.btnClear_TicketSubmission.Size = new System.Drawing.Size(282, 60);
            this.btnClear_TicketSubmission.TabIndex = 29;
            this.btnClear_TicketSubmission.Text = "CLEAR";
            this.btnClear_TicketSubmission.UseVisualStyleBackColor = false;
            // 
            // btnUpdateAdminRights
            // 
            this.btnUpdateAdminRights.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateAdminRights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAdminRights.FlatAppearance.BorderSize = 0;
            this.btnUpdateAdminRights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAdminRights.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAdminRights.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAdminRights.Location = new System.Drawing.Point(338, 365);
            this.btnUpdateAdminRights.Name = "btnUpdateAdminRights";
            this.btnUpdateAdminRights.Size = new System.Drawing.Size(282, 60);
            this.btnUpdateAdminRights.TabIndex = 28;
            this.btnUpdateAdminRights.Text = "UPDATE";
            this.btnUpdateAdminRights.UseVisualStyleBackColor = false;
            this.btnUpdateAdminRights.Click += new System.EventHandler(this.btnUpdateAdminRights_Click);
            // 
            // comboBoxActiveUsers
            // 
            this.comboBoxActiveUsers.FormattingEnabled = true;
            this.comboBoxActiveUsers.Location = new System.Drawing.Point(400, 206);
            this.comboBoxActiveUsers.Name = "comboBoxActiveUsers";
            this.comboBoxActiveUsers.Size = new System.Drawing.Size(415, 33);
            this.comboBoxActiveUsers.TabIndex = 31;
            // 
            // comboBoxAdminRights
            // 
            this.comboBoxAdminRights.FormattingEnabled = true;
            this.comboBoxAdminRights.Location = new System.Drawing.Point(400, 274);
            this.comboBoxAdminRights.Name = "comboBoxAdminRights";
            this.comboBoxAdminRights.Size = new System.Drawing.Size(415, 33);
            this.comboBoxAdminRights.TabIndex = 32;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 638);
            this.Controls.Add(this.comboBoxAdminRights);
            this.Controls.Add(this.comboBoxActiveUsers);
            this.Controls.Add(this.btnBackToLogin_Ticket);
            this.Controls.Add(this.btnClear_TicketSubmission);
            this.Controls.Add(this.btnUpdateAdminRights);
            this.Controls.Add(this.lblAdminRights);
            this.Controls.Add(this.lblUserFirstName);
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserFirstName;
        private System.Windows.Forms.Label lblAdminRights;
        private System.Windows.Forms.Button btnBackToLogin_Ticket;
        private System.Windows.Forms.Button btnClear_TicketSubmission;
        private System.Windows.Forms.Button btnUpdateAdminRights;
        private System.Windows.Forms.ComboBox comboBoxActiveUsers;
        private System.Windows.Forms.ComboBox comboBoxAdminRights;
    }
}