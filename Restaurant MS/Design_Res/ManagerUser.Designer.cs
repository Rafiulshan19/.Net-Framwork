
namespace Design_Res
{
    partial class ManagerUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcome1 = new Design_Res.Presentation_Layer.welcome();
            this.managerMenu_UC1 = new Design_Res.Presentation_Layer.ManagerMenu_UC();
            this.managerViewOrder_UC1 = new Design_Res.Presentation_Layer.ManagerViewOrder_UC();
            this.manageCustomer1 = new Design_Res.Presentation_Layer.ManageCustomer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnManageCustomer = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.welcome1);
            this.panel1.Controls.Add(this.managerMenu_UC1);
            this.panel1.Controls.Add(this.managerViewOrder_UC1);
            this.panel1.Controls.Add(this.manageCustomer1);
            this.panel1.Location = new System.Drawing.Point(192, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 375);
            this.panel1.TabIndex = 13;
            // 
            // welcome1
            // 
            this.welcome1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.welcome1.Location = new System.Drawing.Point(3, 0);
            this.welcome1.Name = "welcome1";
            this.welcome1.Size = new System.Drawing.Size(706, 375);
            this.welcome1.TabIndex = 3;
            this.welcome1.Load += new System.EventHandler(this.welcome1_Load_1);
            // 
            // managerMenu_UC1
            // 
            this.managerMenu_UC1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.managerMenu_UC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.managerMenu_UC1.Location = new System.Drawing.Point(3, 0);
            this.managerMenu_UC1.Name = "managerMenu_UC1";
            this.managerMenu_UC1.Size = new System.Drawing.Size(704, 372);
            this.managerMenu_UC1.TabIndex = 2;
            // 
            // managerViewOrder_UC1
            // 
            this.managerViewOrder_UC1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.managerViewOrder_UC1.Location = new System.Drawing.Point(3, 1);
            this.managerViewOrder_UC1.Name = "managerViewOrder_UC1";
            this.managerViewOrder_UC1.Size = new System.Drawing.Size(706, 374);
            this.managerViewOrder_UC1.TabIndex = 1;
            // 
            // manageCustomer1
            // 
            this.manageCustomer1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.manageCustomer1.Location = new System.Drawing.Point(3, 0);
            this.manageCustomer1.Name = "manageCustomer1";
            this.manageCustomer1.Size = new System.Drawing.Size(706, 375);
            this.manageCustomer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.btnManageCustomer);
            this.panel2.Controls.Add(this.btnViewOrder);
            this.panel2.Location = new System.Drawing.Point(9, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 375);
            this.panel2.TabIndex = 14;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(46, 337);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 25);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBox1.Image = global::Design_Res.Properties.Resources.manager1;
            this.pictureBox1.Location = new System.Drawing.Point(11, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "MANAGER";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnMenu.Image = global::Design_Res.Properties.Resources.items_32x321;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(11, 293);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(179, 33);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menu             ";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnManageCustomer.FlatAppearance.BorderSize = 0;
            this.btnManageCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnManageCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnManageCustomer.Image = global::Design_Res.Properties.Resources.circle_cropped_1_1_30x301;
            this.btnManageCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCustomer.Location = new System.Drawing.Point(11, 215);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(209, 39);
            this.btnManageCustomer.TabIndex = 8;
            this.btnManageCustomer.Text = "Manage Customer";
            this.btnManageCustomer.UseVisualStyleBackColor = false;
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManageCustomer_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnViewOrder.FlatAppearance.BorderSize = 0;
            this.btnViewOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnViewOrder.Image = global::Design_Res.Properties.Resources.order_32x321;
            this.btnViewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewOrder.Location = new System.Drawing.Point(11, 252);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(209, 37);
            this.btnViewOrder.TabIndex = 5;
            this.btnViewOrder.Text = "View Order           ";
            this.btnViewOrder.UseVisualStyleBackColor = false;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // ManagerUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ManagerUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnManageCustomer;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private Presentation_Layer.ManageCustomer manageCustomer1;
        private Presentation_Layer.ManagerViewOrder_UC managerViewOrder_UC1;
        private Presentation_Layer.ManagerMenu_UC managerMenu_UC1;
        private Presentation_Layer.welcome welcome1;
    }
}