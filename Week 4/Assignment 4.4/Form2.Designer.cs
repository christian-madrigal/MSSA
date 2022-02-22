
namespace Assignment_4._4
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
            this.gridCoffeeList = new System.Windows.Forms.DataGridView();
            this.grpCoffee = new System.Windows.Forms.GroupBox();
            this.cmbMilk = new System.Windows.Forms.ComboBox();
            this.cmbBean = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMilk = new System.Windows.Forms.Label();
            this.lblBean = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCoffeeType = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCoffeeList)).BeginInit();
            this.grpCoffee.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCoffeeList
            // 
            this.gridCoffeeList.AllowUserToOrderColumns = true;
            this.gridCoffeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCoffeeList.Location = new System.Drawing.Point(445, 12);
            this.gridCoffeeList.Name = "gridCoffeeList";
            this.gridCoffeeList.Size = new System.Drawing.Size(670, 150);
            this.gridCoffeeList.TabIndex = 0;
            this.gridCoffeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.coffeeGrid_CellContentClick);
            // 
            // grpCoffee
            // 
            this.grpCoffee.BackColor = System.Drawing.Color.Transparent;
            this.grpCoffee.Controls.Add(this.cmbMilk);
            this.grpCoffee.Controls.Add(this.cmbBean);
            this.grpCoffee.Controls.Add(this.txtPrice);
            this.grpCoffee.Controls.Add(this.txtTemp);
            this.grpCoffee.Controls.Add(this.txtSize);
            this.grpCoffee.Controls.Add(this.txtName);
            this.grpCoffee.Controls.Add(this.txtOrderID);
            this.grpCoffee.Controls.Add(this.lblPrice);
            this.grpCoffee.Controls.Add(this.lblMilk);
            this.grpCoffee.Controls.Add(this.lblBean);
            this.grpCoffee.Controls.Add(this.lblTemp);
            this.grpCoffee.Controls.Add(this.lblSize);
            this.grpCoffee.Controls.Add(this.lblCoffeeType);
            this.grpCoffee.Controls.Add(this.lblOrderID);
            this.grpCoffee.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCoffee.ForeColor = System.Drawing.Color.Lime;
            this.grpCoffee.Location = new System.Drawing.Point(12, 93);
            this.grpCoffee.Name = "grpCoffee";
            this.grpCoffee.Size = new System.Drawing.Size(315, 452);
            this.grpCoffee.TabIndex = 1;
            this.grpCoffee.TabStop = false;
            this.grpCoffee.Text = "Coffee Information";
            // 
            // cmbMilk
            // 
            this.cmbMilk.FormattingEnabled = true;
            this.cmbMilk.Location = new System.Drawing.Point(154, 317);
            this.cmbMilk.Name = "cmbMilk";
            this.cmbMilk.Size = new System.Drawing.Size(121, 31);
            this.cmbMilk.TabIndex = 13;
            // 
            // cmbBean
            // 
            this.cmbBean.FormattingEnabled = true;
            this.cmbBean.Location = new System.Drawing.Point(154, 258);
            this.cmbBean.Name = "cmbBean";
            this.cmbBean.Size = new System.Drawing.Size(121, 31);
            this.cmbBean.TabIndex = 12;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(154, 378);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 32);
            this.txtPrice.TabIndex = 11;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(154, 205);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 32);
            this.txtTemp.TabIndex = 10;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(154, 154);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 32);
            this.txtSize.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 32);
            this.txtName.TabIndex = 8;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(154, 37);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 32);
            this.txtOrderID.TabIndex = 7;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 381);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 23);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // lblMilk
            // 
            this.lblMilk.AutoSize = true;
            this.lblMilk.Location = new System.Drawing.Point(6, 320);
            this.lblMilk.Name = "lblMilk";
            this.lblMilk.Size = new System.Drawing.Size(110, 23);
            this.lblMilk.TabIndex = 5;
            this.lblMilk.Text = "Milk Type";
            // 
            // lblBean
            // 
            this.lblBean.AutoSize = true;
            this.lblBean.Location = new System.Drawing.Point(6, 261);
            this.lblBean.Name = "lblBean";
            this.lblBean.Size = new System.Drawing.Size(125, 23);
            this.lblBean.TabIndex = 4;
            this.lblBean.Text = "Bean Origin";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(6, 205);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(118, 23);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "Temperture";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(6, 154);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(50, 23);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Size";
            // 
            // lblCoffeeType
            // 
            this.lblCoffeeType.AutoSize = true;
            this.lblCoffeeType.Location = new System.Drawing.Point(6, 100);
            this.lblCoffeeType.Name = "lblCoffeeType";
            this.lblCoffeeType.Size = new System.Drawing.Size(127, 23);
            this.lblCoffeeType.TabIndex = 1;
            this.lblCoffeeType.Text = "Coffee Type";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(6, 46);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(88, 23);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "OrderID";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Viner Hand ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(972, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Coffee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Viner Hand ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(972, 434);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete Coffee";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Viner Hand ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(994, 491);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 557);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpCoffee);
            this.Controls.Add(this.gridCoffeeList);
            this.Name = "Form2";
            this.Text = "Coffee List";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCoffeeList)).EndInit();
            this.grpCoffee.ResumeLayout(false);
            this.grpCoffee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCoffeeList;
        private System.Windows.Forms.GroupBox grpCoffee;
        private System.Windows.Forms.ComboBox cmbMilk;
        private System.Windows.Forms.ComboBox cmbBean;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMilk;
        private System.Windows.Forms.Label lblBean;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblCoffeeType;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}