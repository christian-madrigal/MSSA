namespace Assignment_6._2
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
            this.carGrid = new System.Windows.Forms.DataGridView();
            this.VehBox = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblVehVin = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtVehVin = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmitNew = new System.Windows.Forms.Button();
            this.btnUpdateRec = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCurrent = new System.Windows.Forms.Button();
            this.btnSold = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carGrid)).BeginInit();
            this.VehBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // carGrid
            // 
            this.carGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carGrid.Location = new System.Drawing.Point(216, 12);
            this.carGrid.Name = "carGrid";
            this.carGrid.Size = new System.Drawing.Size(648, 171);
            this.carGrid.TabIndex = 1;
            // 
            // VehBox
            // 
            this.VehBox.BackColor = System.Drawing.Color.Transparent;
            this.VehBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.VehBox.Controls.Add(this.cmbStatus);
            this.VehBox.Controls.Add(this.lblStatus);
            this.VehBox.Controls.Add(this.lblPrice);
            this.VehBox.Controls.Add(this.lblYear);
            this.VehBox.Controls.Add(this.lblColor);
            this.VehBox.Controls.Add(this.lblModel);
            this.VehBox.Controls.Add(this.lblMake);
            this.VehBox.Controls.Add(this.lblVehVin);
            this.VehBox.Controls.Add(this.cmbYear);
            this.VehBox.Controls.Add(this.cmbColor);
            this.VehBox.Controls.Add(this.txtPrice);
            this.VehBox.Controls.Add(this.txtModel);
            this.VehBox.Controls.Add(this.txtMake);
            this.VehBox.Controls.Add(this.txtVehVin);
            this.VehBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VehBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.VehBox.Location = new System.Drawing.Point(12, 227);
            this.VehBox.Name = "VehBox";
            this.VehBox.Size = new System.Drawing.Size(343, 328);
            this.VehBox.TabIndex = 2;
            this.VehBox.TabStop = false;
            this.VehBox.Text = "Vehicle Information";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(174, 288);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 27);
            this.cmbStatus.TabIndex = 6;
            this.cmbStatus.Leave += new System.EventHandler(this.cmbStatus_Leave);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(16, 296);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 19);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(16, 256);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 19);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(16, 211);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(99, 19);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "Vehicle Year";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(16, 171);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(111, 19);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Vehicle Color";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(16, 133);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(115, 19);
            this.lblModel.TabIndex = 9;
            this.lblModel.Text = "Vehicle Model";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(16, 93);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(108, 19);
            this.lblMake.TabIndex = 8;
            this.lblMake.Text = "Vehicle Make";
            // 
            // lblVehVin
            // 
            this.lblVehVin.AutoSize = true;
            this.lblVehVin.Location = new System.Drawing.Point(16, 53);
            this.lblVehVin.Name = "lblVehVin";
            this.lblVehVin.Size = new System.Drawing.Size(92, 19);
            this.lblVehVin.TabIndex = 7;
            this.lblVehVin.Text = "Vehicle Vin";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(174, 208);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 27);
            this.cmbYear.TabIndex = 4;
            this.cmbYear.Leave += new System.EventHandler(this.cmbYear_Leave);
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(174, 168);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 27);
            this.cmbColor.TabIndex = 3;
            this.cmbColor.Leave += new System.EventHandler(this.cmbColor_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(174, 253);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 27);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(174, 130);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 27);
            this.txtModel.TabIndex = 2;
            this.txtModel.Leave += new System.EventHandler(this.txtModel_Leave);
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(174, 90);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 27);
            this.txtMake.TabIndex = 1;
            this.txtMake.Leave += new System.EventHandler(this.txtMake_Leave);
            // 
            // txtVehVin
            // 
            this.txtVehVin.Location = new System.Drawing.Point(174, 50);
            this.txtVehVin.Name = "txtVehVin";
            this.txtVehVin.Size = new System.Drawing.Size(100, 27);
            this.txtVehVin.TabIndex = 0;
            this.txtVehVin.Leave += new System.EventHandler(this.txtVehVin_Leave);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNew.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(441, 259);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(441, 323);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(98, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select to Update";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(441, 446);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSubmitNew
            // 
            this.btnSubmitNew.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSubmitNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitNew.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitNew.Location = new System.Drawing.Point(595, 259);
            this.btnSubmitNew.Name = "btnSubmitNew";
            this.btnSubmitNew.Size = new System.Drawing.Size(91, 23);
            this.btnSubmitNew.TabIndex = 8;
            this.btnSubmitNew.Text = "Submit New";
            this.btnSubmitNew.UseVisualStyleBackColor = false;
            this.btnSubmitNew.Click += new System.EventHandler(this.btnSubmitNew_Click);
            // 
            // btnUpdateRec
            // 
            this.btnUpdateRec.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUpdateRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateRec.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRec.Location = new System.Drawing.Point(595, 323);
            this.btnUpdateRec.Name = "btnUpdateRec";
            this.btnUpdateRec.Size = new System.Drawing.Size(98, 23);
            this.btnUpdateRec.TabIndex = 9;
            this.btnUpdateRec.Text = "Update Record";
            this.btnUpdateRec.UseVisualStyleBackColor = false;
            this.btnUpdateRec.Click += new System.EventHandler(this.btnUpdateRec_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(595, 446);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCurrent
            // 
            this.btnCurrent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCurrent.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrent.Location = new System.Drawing.Point(441, 389);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(102, 23);
            this.btnCurrent.TabIndex = 11;
            this.btnCurrent.Text = "Current Stock";
            this.btnCurrent.UseVisualStyleBackColor = false;
            this.btnCurrent.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // btnSold
            // 
            this.btnSold.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSold.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSold.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSold.Location = new System.Drawing.Point(595, 389);
            this.btnSold.Name = "btnSold";
            this.btnSold.Size = new System.Drawing.Size(104, 23);
            this.btnSold.TabIndex = 12;
            this.btnSold.Text = "Cars Sold";
            this.btnSold.UseVisualStyleBackColor = false;
            this.btnSold.Click += new System.EventHandler(this.btnSold_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(767, 517);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 567);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSold);
            this.Controls.Add(this.btnCurrent);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdateRec);
            this.Controls.Add(this.btnSubmitNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.VehBox);
            this.Controls.Add(this.carGrid);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Managment System";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carGrid)).EndInit();
            this.VehBox.ResumeLayout(false);
            this.VehBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView carGrid;
        private System.Windows.Forms.GroupBox VehBox;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblVehVin;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtVehVin;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmitNew;
        private System.Windows.Forms.Button btnUpdateRec;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Button btnSold;
        private System.Windows.Forms.Button btnExit;
    }
}