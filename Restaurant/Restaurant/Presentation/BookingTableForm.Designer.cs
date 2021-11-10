
namespace Restaurant.Presentation
{
    partial class BookingTableForm
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
            this.bookTable_DataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.arrival_Time_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelName = new System.Windows.Forms.Label();
            this.cmbNoOfGuest = new System.Windows.Forms.ComboBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.cmbTableType = new System.Windows.Forms.ComboBox();
            this.labelTableType = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bookTable_DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookTable_DataGridView
            // 
            this.bookTable_DataGridView.AllowUserToAddRows = false;
            this.bookTable_DataGridView.AllowUserToDeleteRows = false;
            this.bookTable_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookTable_DataGridView.Location = new System.Drawing.Point(530, 57);
            this.bookTable_DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.bookTable_DataGridView.Name = "bookTable_DataGridView";
            this.bookTable_DataGridView.ReadOnly = true;
            this.bookTable_DataGridView.RowHeadersWidth = 51;
            this.bookTable_DataGridView.RowTemplate.Height = 24;
            this.bookTable_DataGridView.Size = new System.Drawing.Size(444, 314);
            this.bookTable_DataGridView.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.arrival_Time_DateTimePicker);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.cmbNoOfGuest);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.cmbTableType);
            this.groupBox1.Controls.Add(this.labelTableType);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(505, 461);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Table";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.SeaGreen;
            this.updateButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateButton.Location = new System.Drawing.Point(354, 394);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(102, 38);
            this.updateButton.TabIndex = 33;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Maroon;
            this.deleteButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(232, 394);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 38);
            this.deleteButton.TabIndex = 32;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(168, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 23);
            this.txtName.TabIndex = 19;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Location = new System.Drawing.Point(69, 394);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(146, 38);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Confirm Booking";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(168, 315);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(296, 23);
            this.txtContact.TabIndex = 26;
            // 
            // arrival_Time_DateTimePicker
            // 
            this.arrival_Time_DateTimePicker.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrival_Time_DateTimePicker.Location = new System.Drawing.Point(169, 264);
            this.arrival_Time_DateTimePicker.Name = "arrival_Time_DateTimePicker";
            this.arrival_Time_DateTimePicker.Size = new System.Drawing.Size(296, 23);
            this.arrival_Time_DateTimePicker.TabIndex = 30;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(70, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Name";
            // 
            // cmbNoOfGuest
            // 
            this.cmbNoOfGuest.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNoOfGuest.FormattingEnabled = true;
            this.cmbNoOfGuest.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbNoOfGuest.Location = new System.Drawing.Point(169, 208);
            this.cmbNoOfGuest.Name = "cmbNoOfGuest";
            this.cmbNoOfGuest.Size = new System.Drawing.Size(296, 24);
            this.cmbNoOfGuest.TabIndex = 29;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(70, 97);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(47, 17);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "E-mail";
            // 
            // cmbTableType
            // 
            this.cmbTableType.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTableType.FormattingEnabled = true;
            this.cmbTableType.Items.AddRange(new object[] {
            "For Single",
            "For 2 & More",
            "For 5 Member or more"});
            this.cmbTableType.Location = new System.Drawing.Point(169, 150);
            this.cmbTableType.Name = "cmbTableType";
            this.cmbTableType.Size = new System.Drawing.Size(296, 24);
            this.cmbTableType.TabIndex = 28;
            // 
            // labelTableType
            // 
            this.labelTableType.AutoSize = true;
            this.labelTableType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableType.Location = new System.Drawing.Point(45, 157);
            this.labelTableType.Name = "labelTableType";
            this.labelTableType.Size = new System.Drawing.Size(80, 17);
            this.labelTableType.TabIndex = 21;
            this.labelTableType.Text = "Table Type";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(169, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(296, 23);
            this.txtEmail.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "No. of guests";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Arrival Date & Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Contact  No.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(995, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // BookingTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 514);
            this.Controls.Add(this.bookTable_DataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "BookingTableForm";
            this.Text = "BookingTableForm";
            ((System.ComponentModel.ISupportInitialize)(this.bookTable_DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookTable_DataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.DateTimePicker arrival_Time_DateTimePicker;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox cmbNoOfGuest;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.ComboBox cmbTableType;
        private System.Windows.Forms.Label labelTableType;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}