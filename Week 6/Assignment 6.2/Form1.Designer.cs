namespace Assignment_6._2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMain = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.BackColor = System.Drawing.Color.OrangeRed;
            this.lblMain.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMain.Location = new System.Drawing.Point(260, 65);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(266, 24);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Vehicle Management System";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnter.Location = new System.Drawing.Point(56, 147);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(97, 51);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter System";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(236, 147);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 51);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit System";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUsername.Location = new System.Drawing.Point(16, 29);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(57, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "UserName";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPassword.Location = new System.Drawing.Point(16, 78);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(82, 26);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 5;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(82, 74);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 6;
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.Color.Transparent;
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.Controls.Add(this.btnExit);
            this.grpLogin.Controls.Add(this.txtPass);
            this.grpLogin.Controls.Add(this.btnEnter);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.txtUser);
            this.grpLogin.Location = new System.Drawing.Point(185, 141);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(392, 232);
            this.grpLogin.TabIndex = 7;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.lblMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.GroupBox grpLogin;
    }
}

