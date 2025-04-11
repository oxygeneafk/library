namespace LibrarySystem
{
    partial class LibraryProject
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
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.dateTimeDateOfReceiptUpdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDeliveryDateUpdate = new System.Windows.Forms.DateTimePicker();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblDateOfReceiptUpdate = new System.Windows.Forms.Label();
            this.lblDeliveryDateUpdate = new System.Windows.Forms.Label();
            this.tbxReceivedBookUpdate = new System.Windows.Forms.TextBox();
            this.lbReceivedBookUpdate = new System.Windows.Forms.Label();
            this.tbxPhoneNumberUpdate = new System.Windows.Forms.TextBox();
            this.lblPhoneNumberUpdate = new System.Windows.Forms.Label();
            this.tbxLastNameUpdate = new System.Windows.Forms.TextBox();
            this.lblLastNameUpdate = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.dateTimeDateOfReceipt = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDateOfReceipt = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.tbxReceivedBook = new System.Windows.Forms.TextBox();
            this.lblReceivedBook = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgwInformation = new System.Windows.Forms.DataGridView();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.dateTimeDateOfReceiptUpdate);
            this.gbxUpdate.Controls.Add(this.dateTimeDeliveryDateUpdate);
            this.gbxUpdate.Controls.Add(this.btnRemove);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.lblDateOfReceiptUpdate);
            this.gbxUpdate.Controls.Add(this.lblDeliveryDateUpdate);
            this.gbxUpdate.Controls.Add(this.tbxReceivedBookUpdate);
            this.gbxUpdate.Controls.Add(this.lbReceivedBookUpdate);
            this.gbxUpdate.Controls.Add(this.tbxPhoneNumberUpdate);
            this.gbxUpdate.Controls.Add(this.lblPhoneNumberUpdate);
            this.gbxUpdate.Controls.Add(this.tbxLastNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblLastNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.gbxUpdate.Location = new System.Drawing.Point(356, 190);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(310, 236);
            this.gbxUpdate.TabIndex = 105;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update and Remove User";
            // 
            // dateTimeDateOfReceiptUpdate
            // 
            this.dateTimeDateOfReceiptUpdate.Location = new System.Drawing.Point(90, 160);
            this.dateTimeDateOfReceiptUpdate.Name = "dateTimeDateOfReceiptUpdate";
            this.dateTimeDateOfReceiptUpdate.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDateOfReceiptUpdate.TabIndex = 14;
            // 
            // dateTimeDeliveryDateUpdate
            // 
            this.dateTimeDeliveryDateUpdate.Location = new System.Drawing.Point(90, 137);
            this.dateTimeDeliveryDateUpdate.MaxDate = new System.DateTime(2999, 1, 1, 0, 0, 0, 0);
            this.dateTimeDeliveryDateUpdate.MinDate = new System.DateTime(2023, 3, 25, 0, 0, 0, 0);
            this.dateTimeDeliveryDateUpdate.Name = "dateTimeDeliveryDateUpdate";
            this.dateTimeDeliveryDateUpdate.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDeliveryDateUpdate.TabIndex = 13;
            this.dateTimeDeliveryDateUpdate.Value = new System.DateTime(2023, 4, 3, 0, 0, 0, 0);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(135, 200);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(54, 200);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblDateOfReceiptUpdate
            // 
            this.lblDateOfReceiptUpdate.AutoSize = true;
            this.lblDateOfReceiptUpdate.Location = new System.Drawing.Point(6, 167);
            this.lblDateOfReceiptUpdate.Name = "lblDateOfReceiptUpdate";
            this.lblDateOfReceiptUpdate.Size = new System.Drawing.Size(82, 13);
            this.lblDateOfReceiptUpdate.TabIndex = 10;
            this.lblDateOfReceiptUpdate.Text = "Date of Receipt";
            // 
            // lblDeliveryDateUpdate
            // 
            this.lblDeliveryDateUpdate.AutoSize = true;
            this.lblDeliveryDateUpdate.Location = new System.Drawing.Point(6, 141);
            this.lblDeliveryDateUpdate.Name = "lblDeliveryDateUpdate";
            this.lblDeliveryDateUpdate.Size = new System.Drawing.Size(71, 13);
            this.lblDeliveryDateUpdate.TabIndex = 8;
            this.lblDeliveryDateUpdate.Text = "Delivery Date";
            // 
            // tbxReceivedBookUpdate
            // 
            this.tbxReceivedBookUpdate.Location = new System.Drawing.Point(90, 111);
            this.tbxReceivedBookUpdate.Name = "tbxReceivedBookUpdate";
            this.tbxReceivedBookUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxReceivedBookUpdate.TabIndex = 12;
            // 
            // lbReceivedBookUpdate
            // 
            this.lbReceivedBookUpdate.AutoSize = true;
            this.lbReceivedBookUpdate.Location = new System.Drawing.Point(6, 114);
            this.lbReceivedBookUpdate.Name = "lbReceivedBookUpdate";
            this.lbReceivedBookUpdate.Size = new System.Drawing.Size(81, 13);
            this.lbReceivedBookUpdate.TabIndex = 6;
            this.lbReceivedBookUpdate.Text = "Received Book";
            // 
            // tbxPhoneNumberUpdate
            // 
            this.tbxPhoneNumberUpdate.Location = new System.Drawing.Point(90, 85);
            this.tbxPhoneNumberUpdate.Name = "tbxPhoneNumberUpdate";
            this.tbxPhoneNumberUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxPhoneNumberUpdate.TabIndex = 11;
            this.tbxPhoneNumberUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhoneNumberUpdate_KeyPress);
            // 
            // lblPhoneNumberUpdate
            // 
            this.lblPhoneNumberUpdate.AutoSize = true;
            this.lblPhoneNumberUpdate.Location = new System.Drawing.Point(6, 88);
            this.lblPhoneNumberUpdate.Name = "lblPhoneNumberUpdate";
            this.lblPhoneNumberUpdate.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumberUpdate.TabIndex = 4;
            this.lblPhoneNumberUpdate.Text = "Phone Number";
            // 
            // tbxLastNameUpdate
            // 
            this.tbxLastNameUpdate.Location = new System.Drawing.Point(73, 59);
            this.tbxLastNameUpdate.Name = "tbxLastNameUpdate";
            this.tbxLastNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxLastNameUpdate.TabIndex = 10;
            this.tbxLastNameUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLastNameUpdate_KeyPress);
            // 
            // lblLastNameUpdate
            // 
            this.lblLastNameUpdate.AutoSize = true;
            this.lblLastNameUpdate.Location = new System.Drawing.Point(6, 62);
            this.lblLastNameUpdate.Name = "lblLastNameUpdate";
            this.lblLastNameUpdate.Size = new System.Drawing.Size(55, 13);
            this.lblLastNameUpdate.TabIndex = 2;
            this.lblLastNameUpdate.Text = "LastName";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(73, 34);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxNameUpdate.TabIndex = 9;
            this.tbxNameUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNameUpdate_KeyPress);
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(6, 37);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblNameUpdate.TabIndex = 0;
            this.lblNameUpdate.Text = "Name";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.dateTimeDateOfReceipt);
            this.gbxAdd.Controls.Add(this.dateTimeDeliveryDate);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.lblDateOfReceipt);
            this.gbxAdd.Controls.Add(this.lblDeliveryDate);
            this.gbxAdd.Controls.Add(this.tbxReceivedBook);
            this.gbxAdd.Controls.Add(this.lblReceivedBook);
            this.gbxAdd.Controls.Add(this.tbxPhoneNumber);
            this.gbxAdd.Controls.Add(this.lblPhoneNumber);
            this.gbxAdd.Controls.Add(this.tbxLastName);
            this.gbxAdd.Controls.Add(this.lblLastName);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.gbxAdd.Location = new System.Drawing.Point(12, 229);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(338, 197);
            this.gbxAdd.TabIndex = 104;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a User";
            // 
            // dateTimeDateOfReceipt
            // 
            this.dateTimeDateOfReceipt.CustomFormat = "0/0/0000";
            this.dateTimeDateOfReceipt.Location = new System.Drawing.Point(90, 164);
            this.dateTimeDateOfReceipt.MinDate = new System.DateTime(2023, 3, 28, 0, 0, 0, 0);
            this.dateTimeDateOfReceipt.Name = "dateTimeDateOfReceipt";
            this.dateTimeDateOfReceipt.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDateOfReceipt.TabIndex = 7;
            // 
            // dateTimeDeliveryDate
            // 
            this.dateTimeDeliveryDate.CustomFormat = "None";
            this.dateTimeDeliveryDate.Location = new System.Drawing.Point(90, 141);
            this.dateTimeDeliveryDate.MaxDate = new System.DateTime(2999, 1, 1, 0, 0, 0, 0);
            this.dateTimeDeliveryDate.MinDate = new System.DateTime(2023, 3, 28, 0, 0, 0, 0);
            this.dateTimeDeliveryDate.Name = "dateTimeDeliveryDate";
            this.dateTimeDeliveryDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDeliveryDate.TabIndex = 6;
            this.dateTimeDeliveryDate.Value = new System.DateTime(2023, 4, 3, 0, 0, 0, 0);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(215, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDateOfReceipt
            // 
            this.lblDateOfReceipt.AutoSize = true;
            this.lblDateOfReceipt.Location = new System.Drawing.Point(6, 167);
            this.lblDateOfReceipt.Name = "lblDateOfReceipt";
            this.lblDateOfReceipt.Size = new System.Drawing.Size(82, 13);
            this.lblDateOfReceipt.TabIndex = 10;
            this.lblDateOfReceipt.Text = "Date of Receipt";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(6, 141);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(71, 13);
            this.lblDeliveryDate.TabIndex = 8;
            this.lblDeliveryDate.Text = "Delivery Date";
            // 
            // tbxReceivedBook
            // 
            this.tbxReceivedBook.Location = new System.Drawing.Point(90, 111);
            this.tbxReceivedBook.Name = "tbxReceivedBook";
            this.tbxReceivedBook.Size = new System.Drawing.Size(100, 20);
            this.tbxReceivedBook.TabIndex = 5;
            // 
            // lblReceivedBook
            // 
            this.lblReceivedBook.AutoSize = true;
            this.lblReceivedBook.Location = new System.Drawing.Point(6, 114);
            this.lblReceivedBook.Name = "lblReceivedBook";
            this.lblReceivedBook.Size = new System.Drawing.Size(81, 13);
            this.lblReceivedBook.TabIndex = 6;
            this.lblReceivedBook.Text = "Received Book";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(90, 85);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxPhoneNumber.TabIndex = 4;
            this.tbxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhoneNumber_KeyPress);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(6, 88);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(73, 59);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(100, 20);
            this.tbxLastName.TabIndex = 3;
            this.tbxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLastName_KeyPress);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLastName.Location = new System.Drawing.Point(6, 62);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(55, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "LastName";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(73, 34);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 2;
            this.tbxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxName_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Black;
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(6, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(130, 190);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 101;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSearch.Location = new System.Drawing.Point(38, 193);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(86, 13);
            this.lblSearch.TabIndex = 102;
            this.lblSearch.Text = "Search by Name";
            // 
            // dgwInformation
            // 
            this.dgwInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInformation.Location = new System.Drawing.Point(12, 12);
            this.dgwInformation.Name = "dgwInformation";
            this.dgwInformation.ReadOnly = true;
            this.dgwInformation.Size = new System.Drawing.Size(654, 150);
            this.dgwInformation.TabIndex = 103;
            this.dgwInformation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwInformation_CellClick);
            // 
            // LibraryProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(679, 438);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgwInformation);
            this.Name = "LibraryProject";
            this.Text = "LibraryProject";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.DateTimePicker dateTimeDateOfReceiptUpdate;
        private System.Windows.Forms.DateTimePicker dateTimeDeliveryDateUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblDateOfReceiptUpdate;
        private System.Windows.Forms.Label lblDeliveryDateUpdate;
        private System.Windows.Forms.TextBox tbxReceivedBookUpdate;
        private System.Windows.Forms.Label lbReceivedBookUpdate;
        private System.Windows.Forms.TextBox tbxPhoneNumberUpdate;
        private System.Windows.Forms.Label lblPhoneNumberUpdate;
        private System.Windows.Forms.TextBox tbxLastNameUpdate;
        private System.Windows.Forms.Label lblLastNameUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.DateTimePicker dateTimeDateOfReceipt;
        private System.Windows.Forms.DateTimePicker dateTimeDeliveryDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDateOfReceipt;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.TextBox tbxReceivedBook;
        private System.Windows.Forms.Label lblReceivedBook;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgwInformation;
    }
}