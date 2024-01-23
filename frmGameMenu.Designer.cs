namespace Music_Matcher
{
    partial class frmGameMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlConfirmTab = new System.Windows.Forms.Panel();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.grpBoxError = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.grpBoxLogin = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlMainControls = new System.Windows.Forms.Panel();
            this.btnValidateCredentials = new System.Windows.Forms.Button();
            this.btnNoAccount = new System.Windows.Forms.Button();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.pnlNewAccountControls = new System.Windows.Forms.Panel();
            this.btnCancelAccountCreation = new System.Windows.Forms.Button();
            this.btnConfirmNewAccount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlConfirmTab.SuspendLayout();
            this.grpBoxError.SuspendLayout();
            this.grpBoxLogin.SuspendLayout();
            this.pnlMainControls.SuspendLayout();
            this.pnlNewAccountControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlConfirmTab);
            this.panel1.Controls.Add(this.grpBoxError);
            this.panel1.Controls.Add(this.grpBoxLogin);
            this.panel1.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 300);
            this.panel1.TabIndex = 1;
            // 
            // pnlConfirmTab
            // 
            this.pnlConfirmTab.Controls.Add(this.lblConfirmPass);
            this.pnlConfirmTab.Controls.Add(this.txtConfirmPassword);
            this.pnlConfirmTab.Location = new System.Drawing.Point(3, 158);
            this.pnlConfirmTab.Name = "pnlConfirmTab";
            this.pnlConfirmTab.Size = new System.Drawing.Size(317, 35);
            this.pnlConfirmTab.TabIndex = 11;
            this.pnlConfirmTab.Visible = false;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Location = new System.Drawing.Point(14, 9);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(72, 17);
            this.lblConfirmPass.TabIndex = 7;
            this.lblConfirmPass.Text = "Confirm:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(92, 6);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(219, 25);
            this.txtConfirmPassword.TabIndex = 8;
            // 
            // grpBoxError
            // 
            this.grpBoxError.Controls.Add(this.lblError);
            this.grpBoxError.Location = new System.Drawing.Point(3, 27);
            this.grpBoxError.Name = "grpBoxError";
            this.grpBoxError.Size = new System.Drawing.Size(317, 43);
            this.grpBoxError.TabIndex = 9;
            this.grpBoxError.TabStop = false;
            this.grpBoxError.Text = "Error";
            this.grpBoxError.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(6, 21);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(98, 14);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Error Message";
            // 
            // grpBoxLogin
            // 
            this.grpBoxLogin.Controls.Add(this.txtPassword);
            this.grpBoxLogin.Controls.Add(this.txtUsername);
            this.grpBoxLogin.Controls.Add(this.lblPassword);
            this.grpBoxLogin.Controls.Add(this.lblUsername);
            this.grpBoxLogin.Controls.Add(this.pnlMainControls);
            this.grpBoxLogin.Controls.Add(this.pnlNewAccountControls);
            this.grpBoxLogin.Location = new System.Drawing.Point(3, 3);
            this.grpBoxLogin.Name = "grpBoxLogin";
            this.grpBoxLogin.Size = new System.Drawing.Size(317, 294);
            this.grpBoxLogin.TabIndex = 0;
            this.grpBoxLogin.TabStop = false;
            this.grpBoxLogin.Text = "Login";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(92, 124);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(219, 25);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(92, 84);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(219, 25);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 127);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 87);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(80, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // pnlMainControls
            // 
            this.pnlMainControls.Controls.Add(this.btnValidateCredentials);
            this.pnlMainControls.Controls.Add(this.btnNoAccount);
            this.pnlMainControls.Controls.Add(this.btnNewAccount);
            this.pnlMainControls.Location = new System.Drawing.Point(3, 190);
            this.pnlMainControls.Name = "pnlMainControls";
            this.pnlMainControls.Size = new System.Drawing.Size(311, 107);
            this.pnlMainControls.TabIndex = 9;
            // 
            // btnValidateCredentials
            // 
            this.btnValidateCredentials.Location = new System.Drawing.Point(3, 22);
            this.btnValidateCredentials.Name = "btnValidateCredentials";
            this.btnValidateCredentials.Size = new System.Drawing.Size(87, 56);
            this.btnValidateCredentials.TabIndex = 4;
            this.btnValidateCredentials.Text = "Login";
            this.btnValidateCredentials.UseVisualStyleBackColor = true;
            this.btnValidateCredentials.Click += new System.EventHandler(this.btnValidateCredentials_Click);
            // 
            // btnNoAccount
            // 
            this.btnNoAccount.Location = new System.Drawing.Point(109, 15);
            this.btnNoAccount.Name = "btnNoAccount";
            this.btnNoAccount.Size = new System.Drawing.Size(87, 70);
            this.btnNoAccount.TabIndex = 5;
            this.btnNoAccount.Text = "Play Without Account";
            this.btnNoAccount.UseVisualStyleBackColor = true;
            this.btnNoAccount.Click += new System.EventHandler(this.btnNoAccount_Click);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Location = new System.Drawing.Point(215, 22);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(87, 56);
            this.btnNewAccount.TabIndex = 6;
            this.btnNewAccount.Text = "Create Account";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // pnlNewAccountControls
            // 
            this.pnlNewAccountControls.Controls.Add(this.btnCancelAccountCreation);
            this.pnlNewAccountControls.Controls.Add(this.btnConfirmNewAccount);
            this.pnlNewAccountControls.Location = new System.Drawing.Point(6, 194);
            this.pnlNewAccountControls.Name = "pnlNewAccountControls";
            this.pnlNewAccountControls.Size = new System.Drawing.Size(305, 100);
            this.pnlNewAccountControls.TabIndex = 10;
            this.pnlNewAccountControls.Visible = false;
            // 
            // btnCancelAccountCreation
            // 
            this.btnCancelAccountCreation.Location = new System.Drawing.Point(176, 19);
            this.btnCancelAccountCreation.Name = "btnCancelAccountCreation";
            this.btnCancelAccountCreation.Size = new System.Drawing.Size(103, 63);
            this.btnCancelAccountCreation.TabIndex = 1;
            this.btnCancelAccountCreation.Text = "Cancel";
            this.btnCancelAccountCreation.UseVisualStyleBackColor = true;
            this.btnCancelAccountCreation.Click += new System.EventHandler(this.btnCancelAccountCreation_Click);
            // 
            // btnConfirmNewAccount
            // 
            this.btnConfirmNewAccount.Location = new System.Drawing.Point(27, 19);
            this.btnConfirmNewAccount.Name = "btnConfirmNewAccount";
            this.btnConfirmNewAccount.Size = new System.Drawing.Size(103, 63);
            this.btnConfirmNewAccount.TabIndex = 0;
            this.btnConfirmNewAccount.Text = "Create Account";
            this.btnConfirmNewAccount.UseVisualStyleBackColor = true;
            this.btnConfirmNewAccount.Click += new System.EventHandler(this.btnConfirmNewAccount_Click);
            // 
            // frmGameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 324);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Menu";
            this.Load += new System.EventHandler(this.frmGameMenu_Load);
            this.panel1.ResumeLayout(false);
            this.pnlConfirmTab.ResumeLayout(false);
            this.pnlConfirmTab.PerformLayout();
            this.grpBoxError.ResumeLayout(false);
            this.grpBoxError.PerformLayout();
            this.grpBoxLogin.ResumeLayout(false);
            this.grpBoxLogin.PerformLayout();
            this.pnlMainControls.ResumeLayout(false);
            this.pnlNewAccountControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox grpBoxLogin;
        private Label lblUsername;
        private GroupBox grpBoxError;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPass;
        private Button btnNewAccount;
        private Button btnNoAccount;
        private Button btnValidateCredentials;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblPassword;
        private Label lblError;
        private Panel pnlMainControls;
        private Panel pnlNewAccountControls;
        private Button btnCancelAccountCreation;
        private Button btnConfirmNewAccount;
        private Panel pnlConfirmTab;
    }
}