
namespace Assignment_5._3
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
            this.grpEmp = new System.Windows.Forms.GroupBox();
            this.cmbPos = new System.Windows.Forms.ComboBox();
            this.lblFullPart = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblSerialization = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpEmp.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmp
            // 
            this.grpEmp.BackColor = System.Drawing.Color.Transparent;
            this.grpEmp.Controls.Add(this.cmbPos);
            this.grpEmp.Controls.Add(this.lblFullPart);
            this.grpEmp.Controls.Add(this.lblName);
            this.grpEmp.Controls.Add(this.lblEmp);
            this.grpEmp.Controls.Add(this.txtName);
            this.grpEmp.Controls.Add(this.txtEmpID);
            this.grpEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmp.ForeColor = System.Drawing.Color.Lime;
            this.grpEmp.Location = new System.Drawing.Point(46, 141);
            this.grpEmp.Name = "grpEmp";
            this.grpEmp.Size = new System.Drawing.Size(364, 225);
            this.grpEmp.TabIndex = 5;
            this.grpEmp.TabStop = false;
            this.grpEmp.Text = "Employee Information";
            // 
            // cmbPos
            // 
            this.cmbPos.FormattingEnabled = true;
            this.cmbPos.Location = new System.Drawing.Point(229, 155);
            this.cmbPos.Name = "cmbPos";
            this.cmbPos.Size = new System.Drawing.Size(121, 28);
            this.cmbPos.TabIndex = 7;
            // 
            // lblFullPart
            // 
            this.lblFullPart.AutoSize = true;
            this.lblFullPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullPart.ForeColor = System.Drawing.Color.Snow;
            this.lblFullPart.Location = new System.Drawing.Point(54, 154);
            this.lblFullPart.Name = "lblFullPart";
            this.lblFullPart.Size = new System.Drawing.Size(90, 26);
            this.lblFullPart.TabIndex = 6;
            this.lblFullPart.Text = "Position";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Snow;
            this.lblName.Location = new System.Drawing.Point(54, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 26);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Full Name";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.ForeColor = System.Drawing.Color.Snow;
            this.lblEmp.Location = new System.Drawing.Point(54, 43);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(138, 26);
            this.lblEmp.TabIndex = 4;
            this.lblEmp.Text = "Employee ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(229, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(229, 49);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(100, 26);
            this.txtEmpID.TabIndex = 3;
            // 
            // lblSerialization
            // 
            this.lblSerialization.AutoSize = true;
            this.lblSerialization.BackColor = System.Drawing.Color.Transparent;
            this.lblSerialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialization.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSerialization.Location = new System.Drawing.Point(348, 45);
            this.lblSerialization.Name = "lblSerialization";
            this.lblSerialization.Size = new System.Drawing.Size(131, 26);
            this.lblSerialization.TabIndex = 6;
            this.lblSerialization.Text = "Serialization";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 24);
            this.Menu.TabIndex = 7;
            this.Menu.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deserializationToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save As";
            // 
            // deserializationToolStripMenuItem
            // 
            this.deserializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem2,
            this.jSONToolStripMenuItem1,
            this.xMLToolStripMenuItem1});
            this.deserializationToolStripMenuItem.Name = "deserializationToolStripMenuItem";
            this.deserializationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deserializationToolStripMenuItem.Text = "Serialization";
            // 
            // binaryToolStripMenuItem2
            // 
            this.binaryToolStripMenuItem2.Name = "binaryToolStripMenuItem2";
            this.binaryToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.binaryToolStripMenuItem2.Text = "Binary";
            this.binaryToolStripMenuItem2.Click += new System.EventHandler(this.binaryToolStripMenuItem2_Click);
            // 
            // jSONToolStripMenuItem1
            // 
            this.jSONToolStripMenuItem1.Name = "jSONToolStripMenuItem1";
            this.jSONToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.jSONToolStripMenuItem1.Text = "JSON";
            this.jSONToolStripMenuItem1.Click += new System.EventHandler(this.jSONToolStripMenuItem1_Click);
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.xMLToolStripMenuItem1.Text = "XML";
            this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.xMLToolStripMenuItem1_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Open";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem1,
            this.jSONToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.binaryToolStripMenuItem.Text = "DeSerialization";
            // 
            // binaryToolStripMenuItem1
            // 
            this.binaryToolStripMenuItem1.Name = "binaryToolStripMenuItem1";
            this.binaryToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.binaryToolStripMenuItem1.Text = "De-Binary";
            this.binaryToolStripMenuItem1.Click += new System.EventHandler(this.binaryToolStripMenuItem1_Click);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.jSONToolStripMenuItem.Text = "De-JSON";
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.jSONToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.xMLToolStripMenuItem.Text = "De-XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSerialization);
            this.Controls.Add(this.grpEmp);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "Serialization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpEmp.ResumeLayout(false);
            this.grpEmp.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmp;
        private System.Windows.Forms.ComboBox cmbPos;
        private System.Windows.Forms.Label lblFullPart;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lblSerialization;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

