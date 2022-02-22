
namespace Assignment_5._1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.empGrid = new System.Windows.Forms.DataGridView();
            this.grpEmpInfo = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbDep = new System.Windows.Forms.ComboBox();
            this.txtAddy = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddy = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReturntoMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).BeginInit();
            this.grpEmpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // empGrid
            // 
            this.empGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.empGrid.Location = new System.Drawing.Point(376, 12);
            this.empGrid.Name = "empGrid";
            this.empGrid.Size = new System.Drawing.Size(816, 163);
            this.empGrid.TabIndex = 1;
            // 
            // grpEmpInfo
            // 
            this.grpEmpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpEmpInfo.Controls.Add(this.txtPhone);
            this.grpEmpInfo.Controls.Add(this.dateTimePicker1);
            this.grpEmpInfo.Controls.Add(this.cmbDep);
            this.grpEmpInfo.Controls.Add(this.txtAddy);
            this.grpEmpInfo.Controls.Add(this.txtAge);
            this.grpEmpInfo.Controls.Add(this.txtLname);
            this.grpEmpInfo.Controls.Add(this.txtFname);
            this.grpEmpInfo.Controls.Add(this.txtEmpId);
            this.grpEmpInfo.Controls.Add(this.lblPhone);
            this.grpEmpInfo.Controls.Add(this.lblAddy);
            this.grpEmpInfo.Controls.Add(this.lblAge);
            this.grpEmpInfo.Controls.Add(this.lblDob);
            this.grpEmpInfo.Controls.Add(this.lblDep);
            this.grpEmpInfo.Controls.Add(this.lblLName);
            this.grpEmpInfo.Controls.Add(this.lblFName);
            this.grpEmpInfo.Controls.Add(this.lblEmpID);
            this.grpEmpInfo.Location = new System.Drawing.Point(12, 143);
            this.grpEmpInfo.Name = "grpEmpInfo";
            this.grpEmpInfo.Size = new System.Drawing.Size(354, 475);
            this.grpEmpInfo.TabIndex = 2;
            this.grpEmpInfo.TabStop = false;
            this.grpEmpInfo.Text = "Employment Information";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(206, 429);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 14;
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 235);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmbDep
            // 
            this.cmbDep.FormattingEnabled = true;
            this.cmbDep.Location = new System.Drawing.Point(206, 190);
            this.cmbDep.Name = "cmbDep";
            this.cmbDep.Size = new System.Drawing.Size(121, 21);
            this.cmbDep.TabIndex = 11;
            // 
            // txtAddy
            // 
            this.txtAddy.Location = new System.Drawing.Point(206, 354);
            this.txtAddy.Multiline = true;
            this.txtAddy.Name = "txtAddy";
            this.txtAddy.Size = new System.Drawing.Size(100, 46);
            this.txtAddy.TabIndex = 13;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(206, 294);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 12;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(206, 134);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(100, 20);
            this.txtLname.TabIndex = 10;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(206, 90);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(100, 20);
            this.txtFname.TabIndex = 9;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(206, 42);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(100, 20);
            this.txtEmpId.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(26, 436);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblAddy
            // 
            this.lblAddy.AutoSize = true;
            this.lblAddy.Location = new System.Drawing.Point(26, 361);
            this.lblAddy.Name = "lblAddy";
            this.lblAddy.Size = new System.Drawing.Size(45, 13);
            this.lblAddy.TabIndex = 6;
            this.lblAddy.Text = "Address";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(26, 301);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(26, 241);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(66, 13);
            this.lblDob.TabIndex = 4;
            this.lblDob.Text = "Date of Birth";
            this.lblDob.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(26, 193);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(62, 13);
            this.lblDep.TabIndex = 3;
            this.lblDep.Text = "Department";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(26, 134);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(26, 90);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First Name";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(26, 45);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(84, 13);
            this.lblEmpID.TabIndex = 0;
            this.lblEmpID.Text = "Employement ID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(596, 519);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Employee Information";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(788, 519);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Employee Information";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturntoMain
            // 
            this.btnReturntoMain.Location = new System.Drawing.Point(959, 519);
            this.btnReturntoMain.Name = "btnReturntoMain";
            this.btnReturntoMain.Size = new System.Drawing.Size(96, 39);
            this.btnReturntoMain.TabIndex = 5;
            this.btnReturntoMain.Text = "Return to Main Menu";
            this.btnReturntoMain.UseVisualStyleBackColor = true;
            this.btnReturntoMain.Click += new System.EventHandler(this.btnReturntoMain_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 630);
            this.Controls.Add(this.btnReturntoMain);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpEmpInfo);
            this.Controls.Add(this.empGrid);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Managment System";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).EndInit();
            this.grpEmpInfo.ResumeLayout(false);
            this.grpEmpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView empGrid;
        private System.Windows.Forms.GroupBox grpEmpInfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbDep;
        private System.Windows.Forms.TextBox txtAddy;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddy;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReturntoMain;
        private System.Windows.Forms.TextBox txtPhone;
    }
}