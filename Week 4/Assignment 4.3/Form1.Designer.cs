
namespace Assignment_4._3
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
            this.stuGrid = new System.Windows.Forms.DataGridView();
            this.StudMng = new System.Windows.Forms.Label();
            this.grpStu = new System.Windows.Forms.GroupBox();
            this.lblSID = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblAddy = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtStuid = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtAddy = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.lblMonth = new System.Windows.Forms.Label();
            this.ComboMonth = new System.Windows.Forms.ComboBox();
            this.ComboGrade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.stuGrid)).BeginInit();
            this.grpStu.SuspendLayout();
            this.SuspendLayout();
            // 
            // stuGrid
            // 
            this.stuGrid.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.stuGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuGrid.Location = new System.Drawing.Point(461, 127);
            this.stuGrid.Name = "stuGrid";
            this.stuGrid.Size = new System.Drawing.Size(831, 122);
            this.stuGrid.TabIndex = 0;
            this.stuGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studGrid_CellContentClick);
            // 
            // StudMng
            // 
            this.StudMng.AutoSize = true;
            this.StudMng.BackColor = System.Drawing.Color.Transparent;
            this.StudMng.Font = new System.Drawing.Font("Bradley Hand ITC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudMng.ForeColor = System.Drawing.Color.Red;
            this.StudMng.Location = new System.Drawing.Point(687, 34);
            this.StudMng.Name = "StudMng";
            this.StudMng.Size = new System.Drawing.Size(389, 34);
            this.StudMng.TabIndex = 1;
            this.StudMng.Text = "Student Management System";
            this.StudMng.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpStu
            // 
            this.grpStu.BackColor = System.Drawing.Color.Transparent;
            this.grpStu.Controls.Add(this.ComboGrade);
            this.grpStu.Controls.Add(this.ComboMonth);
            this.grpStu.Controls.Add(this.txtAddy);
            this.grpStu.Controls.Add(this.txtLname);
            this.grpStu.Controls.Add(this.txtFname);
            this.grpStu.Controls.Add(this.txtStuid);
            this.grpStu.Controls.Add(this.lblGrade);
            this.grpStu.Controls.Add(this.lblMonth);
            this.grpStu.Controls.Add(this.lblAddy);
            this.grpStu.Controls.Add(this.lblLname);
            this.grpStu.Controls.Add(this.lblFname);
            this.grpStu.Controls.Add(this.lblSID);
            this.grpStu.Location = new System.Drawing.Point(510, 326);
            this.grpStu.Name = "grpStu";
            this.grpStu.Size = new System.Drawing.Size(451, 240);
            this.grpStu.TabIndex = 2;
            this.grpStu.TabStop = false;
            this.grpStu.Text = "Student Information";
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSID.ForeColor = System.Drawing.Color.Transparent;
            this.lblSID.Location = new System.Drawing.Point(24, 26);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(84, 17);
            this.lblSID.TabIndex = 0;
            this.lblSID.Text = "Student ID";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.Transparent;
            this.lblFname.Location = new System.Drawing.Point(24, 65);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(86, 17);
            this.lblFname.TabIndex = 1;
            this.lblFname.Text = "First Name";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.ForeColor = System.Drawing.Color.Transparent;
            this.lblLname.Location = new System.Drawing.Point(24, 98);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(85, 17);
            this.lblLname.TabIndex = 2;
            this.lblLname.Text = "Last Name";
            // 
            // lblAddy
            // 
            this.lblAddy.AutoSize = true;
            this.lblAddy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddy.ForeColor = System.Drawing.Color.Transparent;
            this.lblAddy.Location = new System.Drawing.Point(24, 131);
            this.lblAddy.Name = "lblAddy";
            this.lblAddy.Size = new System.Drawing.Size(67, 17);
            this.lblAddy.TabIndex = 3;
            this.lblAddy.Text = "Address";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.Color.Transparent;
            this.lblGrade.Location = new System.Drawing.Point(24, 194);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(53, 17);
            this.lblGrade.TabIndex = 5;
            this.lblGrade.Text = "Grade";
            // 
            // txtStuid
            // 
            this.txtStuid.Location = new System.Drawing.Point(183, 25);
            this.txtStuid.Name = "txtStuid";
            this.txtStuid.Size = new System.Drawing.Size(100, 20);
            this.txtStuid.TabIndex = 6;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(183, 62);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(100, 20);
            this.txtFname.TabIndex = 7;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(183, 95);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(100, 20);
            this.txtLname.TabIndex = 8;
            // 
            // txtAddy
            // 
            this.txtAddy.Location = new System.Drawing.Point(183, 128);
            this.txtAddy.Name = "txtAddy";
            this.txtAddy.Size = new System.Drawing.Size(100, 20);
            this.txtAddy.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1040, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1040, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRecord.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnRecord.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(1040, 448);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(109, 34);
            this.btnRecord.TabIndex = 5;
            this.btnRecord.Text = "Display Record";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.Transparent;
            this.lblMonth.Location = new System.Drawing.Point(24, 164);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(149, 17);
            this.lblMonth.TabIndex = 4;
            this.lblMonth.Text = "Month of Admission";
            // 
            // ComboMonth
            // 
            this.ComboMonth.FormattingEnabled = true;
            this.ComboMonth.Location = new System.Drawing.Point(183, 160);
            this.ComboMonth.Name = "ComboMonth";
            this.ComboMonth.Size = new System.Drawing.Size(121, 21);
            this.ComboMonth.TabIndex = 12;
            // 
            // ComboGrade
            // 
            this.ComboGrade.FormattingEnabled = true;
            this.ComboGrade.Location = new System.Drawing.Point(183, 190);
            this.ComboGrade.Name = "ComboGrade";
            this.ComboGrade.Size = new System.Drawing.Size(121, 21);
            this.ComboGrade.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1799, 831);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpStu);
            this.Controls.Add(this.StudMng);
            this.Controls.Add(this.stuGrid);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stuGrid)).EndInit();
            this.grpStu.ResumeLayout(false);
            this.grpStu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stuGrid;
        private System.Windows.Forms.Label StudMng;
        private System.Windows.Forms.GroupBox grpStu;
        private System.Windows.Forms.TextBox txtAddy;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtStuid;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblAddy;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.ComboBox ComboMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox ComboGrade;
    }
}

