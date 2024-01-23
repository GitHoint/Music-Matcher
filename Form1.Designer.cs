namespace Music_Matcher
{
    partial class frmStartMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcomeMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetStarted = new System.Windows.Forms.Button();
            this.btnSetupGuide = new System.Windows.Forms.Button();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcomeMsg
            // 
            this.lblWelcomeMsg.AutoSize = true;
            this.lblWelcomeMsg.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcomeMsg.Location = new System.Drawing.Point(46, 9);
            this.lblWelcomeMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcomeMsg.Name = "lblWelcomeMsg";
            this.lblWelcomeMsg.Size = new System.Drawing.Size(425, 37);
            this.lblWelcomeMsg.TabIndex = 0;
            this.lblWelcomeMsg.Text = "Welcome to Music Matcher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "How Well Do You Know Your Playlist?";
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetStarted.Location = new System.Drawing.Point(156, 187);
            this.btnGetStarted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.Size = new System.Drawing.Size(193, 122);
            this.btnGetStarted.TabIndex = 2;
            this.btnGetStarted.Text = "Get Started";
            this.btnGetStarted.UseVisualStyleBackColor = true;
            this.btnGetStarted.Click += new System.EventHandler(this.btnGetStarted_Click);
            // 
            // btnSetupGuide
            // 
            this.btnSetupGuide.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSetupGuide.Location = new System.Drawing.Point(17, 398);
            this.btnSetupGuide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetupGuide.Name = "btnSetupGuide";
            this.btnSetupGuide.Size = new System.Drawing.Size(193, 122);
            this.btnSetupGuide.TabIndex = 4;
            this.btnSetupGuide.Text = "Playlist Setup";
            this.btnSetupGuide.UseVisualStyleBackColor = true;
            this.btnSetupGuide.Click += new System.EventHandler(this.btnSetupGuide_Click);
            // 
            // btnTutorial
            // 
            this.btnTutorial.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTutorial.Location = new System.Drawing.Point(286, 398);
            this.btnTutorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(193, 122);
            this.btnTutorial.TabIndex = 5;
            this.btnTutorial.Text = "How It Works";
            this.btnTutorial.UseVisualStyleBackColor = true;
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // lblAdvice
            // 
            this.lblAdvice.AutoSize = true;
            this.lblAdvice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdvice.Location = new System.Drawing.Point(55, 332);
            this.lblAdvice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(400, 25);
            this.lblAdvice.TabIndex = 6;
            this.lblAdvice.Text = "*First time players should read before playing*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(156, 368);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "\\/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(324, 368);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "\\/";
            // 
            // frmStartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 540);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAdvice);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.btnSetupGuide);
            this.Controls.Add(this.btnGetStarted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcomeMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmStartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblWelcomeMsg;
        private Label label1;
        private Button btnGetStarted;
        private Button btnSetupGuide;
        private Button btnTutorial;
        private Label lblAdvice;
        private Label label2;
        private Label label3;
    }
}