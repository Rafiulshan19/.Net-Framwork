
namespace Design_Res.Presentation_Layer
{
    partial class CustomerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMenu));
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1Category = new System.Windows.Forms.ComboBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.lbCatagory = new System.Windows.Forms.Label();
            this.lbFoodName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView_Menu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnViewFoodItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Menu)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backToolStripMenuItem.Image")));
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
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
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // comboBox1Category
            // 
            this.comboBox1Category.FormattingEnabled = true;
            this.comboBox1Category.Items.AddRange(new object[] {
            "Fast Food",
            "Indian",
            "Italian",
            "Thai Chinese",
            "Desserts",
            "Drinks"});
            this.comboBox1Category.Location = new System.Drawing.Point(242, 44);
            this.comboBox1Category.Name = "comboBox1Category";
            this.comboBox1Category.Size = new System.Drawing.Size(112, 21);
            this.comboBox1Category.TabIndex = 55;
            this.comboBox1Category.SelectedIndexChanged += new System.EventHandler(this.comboBox1Category_SelectedIndexChanged);
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(492, 45);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(112, 20);
            this.txtFoodName.TabIndex = 53;
            // 
            // lbCatagory
            // 
            this.lbCatagory.AutoSize = true;
            this.lbCatagory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbCatagory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCatagory.Location = new System.Drawing.Point(173, 47);
            this.lbCatagory.Name = "lbCatagory";
            this.lbCatagory.Size = new System.Drawing.Size(63, 16);
            this.lbCatagory.TabIndex = 52;
            this.lbCatagory.Text = "Catagory";
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbFoodName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodName.Location = new System.Drawing.Point(406, 45);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(80, 16);
            this.lbFoodName.TabIndex = 50;
            this.lbFoodName.Text = "Food Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(610, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 20);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView_Menu
            // 
            this.dataGridView_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView_Menu.Location = new System.Drawing.Point(25, 81);
            this.dataGridView_Menu.Name = "dataGridView_Menu";
            this.dataGridView_Menu.Size = new System.Drawing.Size(653, 261);
            this.dataGridView_Menu.TabIndex = 48;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Food Category";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Food Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSalmon;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnViewFoodItems
            // 
            this.btnViewFoodItems.Location = new System.Drawing.Point(25, 37);
            this.btnViewFoodItems.Name = "btnViewFoodItems";
            this.btnViewFoodItems.Size = new System.Drawing.Size(104, 28);
            this.btnViewFoodItems.TabIndex = 62;
            this.btnViewFoodItems.Text = "View Food Items";
            this.btnViewFoodItems.UseVisualStyleBackColor = true;
            this.btnViewFoodItems.Click += new System.EventHandler(this.btnViewFoodItems_Click);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.btnViewFoodItems);
            this.Controls.Add(this.comboBox1Category);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.lbCatagory);
            this.Controls.Add(this.lbFoodName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView_Menu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CustomerMenu";
            this.Size = new System.Drawing.Size(706, 374);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Menu)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1Category;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label lbCatagory;
        private System.Windows.Forms.Label lbFoodName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView_Menu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnViewFoodItems;
    }
}
