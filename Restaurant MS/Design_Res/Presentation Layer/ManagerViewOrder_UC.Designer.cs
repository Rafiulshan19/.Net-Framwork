
namespace Design_Res.Presentation_Layer
{
    partial class ManagerViewOrder_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerViewOrder_UC));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbFoodCategory = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.ComboBoxFoodCategory = new System.Windows.Forms.ComboBox();
            this.txtFoodItem = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbFoodItem = new System.Windows.Forms.Label();
            this.lbAddOrder = new System.Windows.Forms.Label();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.lbtotal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aquamarine;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backToolStripMenuItem.Image")));
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // lbFoodCategory
            // 
            this.lbFoodCategory.AutoSize = true;
            this.lbFoodCategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbFoodCategory.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbFoodCategory.Location = new System.Drawing.Point(27, 101);
            this.lbFoodCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFoodCategory.Name = "lbFoodCategory";
            this.lbFoodCategory.Size = new System.Drawing.Size(81, 14);
            this.lbFoodCategory.TabIndex = 52;
            this.lbFoodCategory.Text = "Food Category";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(143, 153);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(128, 23);
            this.txtPrice.TabIndex = 50;
            // 
            // ComboBoxFoodCategory
            // 
            this.ComboBoxFoodCategory.FormattingEnabled = true;
            this.ComboBoxFoodCategory.Items.AddRange(new object[] {
            "Fast Food",
            "Indian",
            "Italian",
            "Thai Chinese",
            "Desserts",
            "Drinks"});
            this.ComboBoxFoodCategory.Location = new System.Drawing.Point(143, 98);
            this.ComboBoxFoodCategory.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxFoodCategory.Name = "ComboBoxFoodCategory";
            this.ComboBoxFoodCategory.Size = new System.Drawing.Size(128, 21);
            this.ComboBoxFoodCategory.TabIndex = 51;
            // 
            // txtFoodItem
            // 
            this.txtFoodItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodItem.Location = new System.Drawing.Point(143, 125);
            this.txtFoodItem.Margin = new System.Windows.Forms.Padding(2);
            this.txtFoodItem.Name = "txtFoodItem";
            this.txtFoodItem.Size = new System.Drawing.Size(128, 23);
            this.txtFoodItem.TabIndex = 49;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Black;
            this.lbPrice.Location = new System.Drawing.Point(31, 157);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(35, 15);
            this.lbPrice.TabIndex = 48;
            this.lbPrice.Text = "Price";
            // 
            // lbFoodItem
            // 
            this.lbFoodItem.AutoSize = true;
            this.lbFoodItem.BackColor = System.Drawing.SystemColors.Control;
            this.lbFoodItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodItem.ForeColor = System.Drawing.Color.Black;
            this.lbFoodItem.Location = new System.Drawing.Point(31, 129);
            this.lbFoodItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFoodItem.Name = "lbFoodItem";
            this.lbFoodItem.Size = new System.Drawing.Size(62, 15);
            this.lbFoodItem.TabIndex = 47;
            this.lbFoodItem.Text = "Food Item";
            // 
            // lbAddOrder
            // 
            this.lbAddOrder.AutoSize = true;
            this.lbAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddOrder.Location = new System.Drawing.Point(60, 40);
            this.lbAddOrder.Name = "lbAddOrder";
            this.lbAddOrder.Size = new System.Drawing.Size(181, 29);
            this.lbAddOrder.TabIndex = 53;
            this.lbAddOrder.Text = "Manage Order";
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveOrder.Location = new System.Drawing.Point(157, 218);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(114, 30);
            this.btnRemoveOrder.TabIndex = 63;
            this.btnRemoveOrder.Text = "Remove Order";
            this.btnRemoveOrder.UseVisualStyleBackColor = false;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.AutoSize = true;
            this.lbTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAmount.Location = new System.Drawing.Point(38, 316);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(108, 20);
            this.lbTotalAmount.TabIndex = 67;
            this.lbTotalAmount.Text = "Total Amount:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(600, 40);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(34, 13);
            this.lbDate.TabIndex = 70;
            this.lbDate.Text = "Date";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(315, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(363, 276);
            this.dataGridView2.TabIndex = 72;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Food Category";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Food Item";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Price";
            this.Column6.Name = "Column6";
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddtoCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoCart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddtoCart.Location = new System.Drawing.Point(30, 218);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(114, 30);
            this.btnAddtoCart.TabIndex = 73;
            this.btnAddtoCart.Text = "Add Order";
            this.btnAddtoCart.UseVisualStyleBackColor = false;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.BackColor = System.Drawing.Color.Tomato;
            this.lbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.Location = new System.Drawing.Point(152, 312);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(60, 25);
            this.lbtotal.TabIndex = 74;
            this.lbtotal.Text = "Tk. 0";
            // 
            // ManagerViewOrder_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbTotalAmount);
            this.Controls.Add(this.btnRemoveOrder);
            this.Controls.Add(this.lbAddOrder);
            this.Controls.Add(this.lbFoodCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.ComboBoxFoodCategory);
            this.Controls.Add(this.txtFoodItem);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbFoodItem);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ManagerViewOrder_UC";
            this.Size = new System.Drawing.Size(706, 374);
            this.Load += new System.EventHandler(this.ManagerViewOrder_UC_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label lbFoodCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox ComboBoxFoodCategory;
        private System.Windows.Forms.TextBox txtFoodItem;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbFoodItem;
        private System.Windows.Forms.Label lbAddOrder;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lbtotal;
    }
}
