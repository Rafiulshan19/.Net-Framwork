
namespace Design_Res.Presentation_Layer
{
    partial class ManagerMenu_UC
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
            this.btnShowFoodItem = new System.Windows.Forms.Button();
            this.btnUpdateFoodItem = new System.Windows.Forms.Button();
            this.btnRemoveFoodItem = new System.Windows.Forms.Button();
            this.btnAddFoodItem = new System.Windows.Forms.Button();
            this.comboBox1FoodCategory2 = new System.Windows.Forms.ComboBox();
            this.txtFoodPrice = new System.Windows.Forms.TextBox();
            this.txtFoodName2 = new System.Windows.Forms.TextBox();
            this.lbFoodCatagory2 = new System.Windows.Forms.Label();
            this.lbFoodPrice2 = new System.Windows.Forms.Label();
            this.lbFoodName2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1_ManagerMenu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1Search4Category = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_ManagerMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowFoodItem
            // 
            this.btnShowFoodItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShowFoodItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShowFoodItem.FlatAppearance.BorderSize = 0;
            this.btnShowFoodItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnShowFoodItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFoodItem.Location = new System.Drawing.Point(26, 320);
            this.btnShowFoodItem.Name = "btnShowFoodItem";
            this.btnShowFoodItem.Size = new System.Drawing.Size(188, 35);
            this.btnShowFoodItem.TabIndex = 44;
            this.btnShowFoodItem.Text = "Show Food Items";
            this.btnShowFoodItem.UseVisualStyleBackColor = false;
            this.btnShowFoodItem.Click += new System.EventHandler(this.btnShowItem_Click);
            // 
            // btnUpdateFoodItem
            // 
            this.btnUpdateFoodItem.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnUpdateFoodItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateFoodItem.FlatAppearance.BorderSize = 0;
            this.btnUpdateFoodItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnUpdateFoodItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFoodItem.Location = new System.Drawing.Point(26, 279);
            this.btnUpdateFoodItem.Name = "btnUpdateFoodItem";
            this.btnUpdateFoodItem.Size = new System.Drawing.Size(188, 35);
            this.btnUpdateFoodItem.TabIndex = 43;
            this.btnUpdateFoodItem.Text = "Update Food Item";
            this.btnUpdateFoodItem.UseVisualStyleBackColor = false;
            this.btnUpdateFoodItem.Click += new System.EventHandler(this.btnUpdateFoodItem_Click);
            // 
            // btnRemoveFoodItem
            // 
            this.btnRemoveFoodItem.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoveFoodItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRemoveFoodItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveFoodItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnRemoveFoodItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFoodItem.Location = new System.Drawing.Point(26, 238);
            this.btnRemoveFoodItem.Name = "btnRemoveFoodItem";
            this.btnRemoveFoodItem.Size = new System.Drawing.Size(188, 35);
            this.btnRemoveFoodItem.TabIndex = 42;
            this.btnRemoveFoodItem.Text = "Delete Food Item";
            this.btnRemoveFoodItem.UseVisualStyleBackColor = false;
            this.btnRemoveFoodItem.Click += new System.EventHandler(this.btnRemoveFoodItem_Click);
            // 
            // btnAddFoodItem
            // 
            this.btnAddFoodItem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddFoodItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddFoodItem.FlatAppearance.BorderSize = 0;
            this.btnAddFoodItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAddFoodItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFoodItem.Location = new System.Drawing.Point(26, 197);
            this.btnAddFoodItem.Name = "btnAddFoodItem";
            this.btnAddFoodItem.Size = new System.Drawing.Size(188, 35);
            this.btnAddFoodItem.TabIndex = 41;
            this.btnAddFoodItem.Text = "Add Food Item";
            this.btnAddFoodItem.UseVisualStyleBackColor = false;
            this.btnAddFoodItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // comboBox1FoodCategory2
            // 
            this.comboBox1FoodCategory2.FormattingEnabled = true;
            this.comboBox1FoodCategory2.Items.AddRange(new object[] {
            "Fast Food",
            "Indian",
            "Italian",
            "Thai Chinese",
            "Desserts",
            "Drinks"});
            this.comboBox1FoodCategory2.Location = new System.Drawing.Point(129, 75);
            this.comboBox1FoodCategory2.Name = "comboBox1FoodCategory2";
            this.comboBox1FoodCategory2.Size = new System.Drawing.Size(136, 21);
            this.comboBox1FoodCategory2.TabIndex = 40;
            this.comboBox1FoodCategory2.SelectedIndexChanged += new System.EventHandler(this.comboBox1FoodCategory2_SelectedIndexChanged);
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Location = new System.Drawing.Point(129, 136);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(136, 20);
            this.txtFoodPrice.TabIndex = 39;
            // 
            // txtFoodName2
            // 
            this.txtFoodName2.Location = new System.Drawing.Point(129, 106);
            this.txtFoodName2.Name = "txtFoodName2";
            this.txtFoodName2.Size = new System.Drawing.Size(136, 20);
            this.txtFoodName2.TabIndex = 38;
            // 
            // lbFoodCatagory2
            // 
            this.lbFoodCatagory2.AutoSize = true;
            this.lbFoodCatagory2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbFoodCatagory2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbFoodCatagory2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodCatagory2.Location = new System.Drawing.Point(25, 80);
            this.lbFoodCatagory2.Name = "lbFoodCatagory2";
            this.lbFoodCatagory2.Size = new System.Drawing.Size(98, 16);
            this.lbFoodCatagory2.TabIndex = 37;
            this.lbFoodCatagory2.Text = "Food Catagory";
            // 
            // lbFoodPrice2
            // 
            this.lbFoodPrice2.AutoSize = true;
            this.lbFoodPrice2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbFoodPrice2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbFoodPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodPrice2.Location = new System.Drawing.Point(25, 139);
            this.lbFoodPrice2.Name = "lbFoodPrice2";
            this.lbFoodPrice2.Size = new System.Drawing.Size(74, 16);
            this.lbFoodPrice2.TabIndex = 36;
            this.lbFoodPrice2.Text = "Food Price";
            // 
            // lbFoodName2
            // 
            this.lbFoodName2.AutoSize = true;
            this.lbFoodName2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbFoodName2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbFoodName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodName2.Location = new System.Drawing.Point(25, 110);
            this.lbFoodName2.Name = "lbFoodName2";
            this.lbFoodName2.Size = new System.Drawing.Size(80, 16);
            this.lbFoodName2.TabIndex = 35;
            this.lbFoodName2.Text = "Food Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(537, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 21);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(414, 62);
            this.txtSearchName.Multiline = true;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(114, 21);
            this.txtSearchName.TabIndex = 32;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aquamarine;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::Design_Res.Properties.Resources.file1;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Image = global::Design_Res.Properties.Resources.back;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::Design_Res.Properties.Resources.logout_img;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 27);
            this.label1.TabIndex = 46;
            this.label1.Text = "Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 47;
            this.label2.Text = "Food Items";
            // 
            // dataGridView1_ManagerMenu
            // 
            this.dataGridView1_ManagerMenu.AllowUserToOrderColumns = true;
            this.dataGridView1_ManagerMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_ManagerMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1_ManagerMenu.Location = new System.Drawing.Point(290, 89);
            this.dataGridView1_ManagerMenu.Name = "dataGridView1_ManagerMenu";
            this.dataGridView1_ManagerMenu.Size = new System.Drawing.Size(396, 266);
            this.dataGridView1_ManagerMenu.TabIndex = 48;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "FoodCategory";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FoodName";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FoodPrice";
            this.Column3.Name = "Column3";
            // 
            // comboBox1Search4Category
            // 
            this.comboBox1Search4Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1Search4Category.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox1Search4Category.FormattingEnabled = true;
            this.comboBox1Search4Category.Items.AddRange(new object[] {
            "Fast Food",
            "Indian",
            "Italian",
            "Thai Chinese",
            "Desserts",
            "Drinks"});
            this.comboBox1Search4Category.Location = new System.Drawing.Point(290, 62);
            this.comboBox1Search4Category.Name = "comboBox1Search4Category";
            this.comboBox1Search4Category.Size = new System.Drawing.Size(114, 21);
            this.comboBox1Search4Category.TabIndex = 49;
            this.comboBox1Search4Category.Text = "Food Category";
            this.comboBox1Search4Category.SelectedIndexChanged += new System.EventHandler(this.comboBox1Search4Category_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(616, 62);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 21);
            this.btnRefresh.TabIndex = 50;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManagerMenu_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.comboBox1Search4Category);
            this.Controls.Add(this.dataGridView1_ManagerMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowFoodItem);
            this.Controls.Add(this.btnUpdateFoodItem);
            this.Controls.Add(this.btnRemoveFoodItem);
            this.Controls.Add(this.btnAddFoodItem);
            this.Controls.Add(this.comboBox1FoodCategory2);
            this.Controls.Add(this.txtFoodPrice);
            this.Controls.Add(this.txtFoodName2);
            this.Controls.Add(this.lbFoodCatagory2);
            this.Controls.Add(this.lbFoodPrice2);
            this.Controls.Add(this.lbFoodName2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ManagerMenu_UC";
            this.Size = new System.Drawing.Size(706, 374);
            this.Load += new System.EventHandler(this.ManagerMenu_UC_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_ManagerMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowFoodItem;
        private System.Windows.Forms.Button btnUpdateFoodItem;
        private System.Windows.Forms.Button btnRemoveFoodItem;
        private System.Windows.Forms.Button btnAddFoodItem;
        private System.Windows.Forms.ComboBox comboBox1FoodCategory2;
        private System.Windows.Forms.TextBox txtFoodPrice;
        private System.Windows.Forms.TextBox txtFoodName2;
        private System.Windows.Forms.Label lbFoodCatagory2;
        private System.Windows.Forms.Label lbFoodPrice2;
        private System.Windows.Forms.Label lbFoodName2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1_ManagerMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox comboBox1Search4Category;
        private System.Windows.Forms.Button btnRefresh;
    }
}
