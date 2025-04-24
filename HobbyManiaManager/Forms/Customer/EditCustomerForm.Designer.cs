namespace HobbyManiaManager.Forms
{
    partial class EditCustomerForm
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
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.textBoxAvatarUrl = new System.Windows.Forms.TextBox();
            this.labelAvatarUrl = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.dateTimePickerRegDate = new System.Windows.Forms.DateTimePicker();
            this.labelName = new System.Windows.Forms.Label();
            this.labelRegDate = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdateCreate = new System.Windows.Forms.Button();
            this.groupBoxActiveRentals = new System.Windows.Forms.GroupBox();
            this.dataGridViewActiveRentals = new System.Windows.Forms.DataGridView();
            this.buttonRentalHistory = new System.Windows.Forms.Button();
            this.groupBoxProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.groupBoxActiveRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.Controls.Add(this.textBoxAvatarUrl);
            this.groupBoxProfile.Controls.Add(this.labelAvatarUrl);
            this.groupBoxProfile.Controls.Add(this.pictureBoxAvatar);
            this.groupBoxProfile.Controls.Add(this.textBoxPhone);
            this.groupBoxProfile.Controls.Add(this.textBoxEmail);
            this.groupBoxProfile.Controls.Add(this.textBoxName);
            this.groupBoxProfile.Controls.Add(this.textBoxId);
            this.groupBoxProfile.Controls.Add(this.dateTimePickerRegDate);
            this.groupBoxProfile.Controls.Add(this.labelName);
            this.groupBoxProfile.Controls.Add(this.labelRegDate);
            this.groupBoxProfile.Controls.Add(this.labelPhone);
            this.groupBoxProfile.Controls.Add(this.labelEmail);
            this.groupBoxProfile.Controls.Add(this.labelId);
            this.groupBoxProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProfile.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(748, 206);
            this.groupBoxProfile.TabIndex = 0;
            this.groupBoxProfile.TabStop = false;
            this.groupBoxProfile.Text = "Profile";
            // 
            // textBoxAvatarUrl
            // 
            this.textBoxAvatarUrl.Location = new System.Drawing.Point(257, 162);
            this.textBoxAvatarUrl.Name = "textBoxAvatarUrl";
            this.textBoxAvatarUrl.Size = new System.Drawing.Size(481, 26);
            this.textBoxAvatarUrl.TabIndex = 12;
            this.textBoxAvatarUrl.TextChanged += new System.EventHandler(this.textBoxAvatarUrl_TextChanged);
            // 
            // labelAvatarUrl
            // 
            this.labelAvatarUrl.AutoSize = true;
            this.labelAvatarUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvatarUrl.Location = new System.Drawing.Point(169, 165);
            this.labelAvatarUrl.Name = "labelAvatarUrl";
            this.labelAvatarUrl.Size = new System.Drawing.Size(79, 20);
            this.labelAvatarUrl.TabIndex = 11;
            this.labelAvatarUrl.Text = "Avatar Url";
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Location = new System.Drawing.Point(6, 32);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 10;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(257, 130);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(481, 26);
            this.textBoxPhone.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(257, 98);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(481, 26);
            this.textBoxEmail.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(257, 66);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(481, 26);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(257, 31);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(101, 26);
            this.textBoxId.TabIndex = 6;
            // 
            // dateTimePickerRegDate
            // 
            this.dateTimePickerRegDate.Location = new System.Drawing.Point(532, 31);
            this.dateTimePickerRegDate.Name = "dateTimePickerRegDate";
            this.dateTimePickerRegDate.Size = new System.Drawing.Size(206, 26);
            this.dateTimePickerRegDate.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(169, 69);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelRegDate
            // 
            this.labelRegDate.AutoSize = true;
            this.labelRegDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegDate.Location = new System.Drawing.Point(444, 34);
            this.labelRegDate.Name = "labelRegDate";
            this.labelRegDate.Size = new System.Drawing.Size(82, 20);
            this.labelRegDate.TabIndex = 4;
            this.labelRegDate.Text = "Reg. Date";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(169, 133);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 20);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Phone";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(169, 101);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(169, 34);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(23, 20);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(685, 466);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdateCreate
            // 
            this.buttonUpdateCreate.Location = new System.Drawing.Point(604, 466);
            this.buttonUpdateCreate.Name = "buttonUpdateCreate";
            this.buttonUpdateCreate.Size = new System.Drawing.Size(75, 27);
            this.buttonUpdateCreate.TabIndex = 2;
            this.buttonUpdateCreate.Text = "Create";
            this.buttonUpdateCreate.UseVisualStyleBackColor = true;
            this.buttonUpdateCreate.Click += new System.EventHandler(this.buttonUpdateCreate_Click);
            // 
            // groupBoxActiveRentals
            // 
            this.groupBoxActiveRentals.Controls.Add(this.dataGridViewActiveRentals);
            this.groupBoxActiveRentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxActiveRentals.Location = new System.Drawing.Point(12, 224);
            this.groupBoxActiveRentals.Name = "groupBoxActiveRentals";
            this.groupBoxActiveRentals.Size = new System.Drawing.Size(748, 236);
            this.groupBoxActiveRentals.TabIndex = 3;
            this.groupBoxActiveRentals.TabStop = false;
            this.groupBoxActiveRentals.Text = "Active Rentals";
            // 
            // dataGridViewActiveRentals
            // 
            this.dataGridViewActiveRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiveRentals.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewActiveRentals.Name = "dataGridViewActiveRentals";
            this.dataGridViewActiveRentals.Size = new System.Drawing.Size(731, 208);
            this.dataGridViewActiveRentals.TabIndex = 0;
            this.dataGridViewActiveRentals.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActiveRentals_CellDoubleClick);
            this.dataGridViewActiveRentals.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // buttonRentalHistory
            // 
            this.buttonRentalHistory.Location = new System.Drawing.Point(12, 466);
            this.buttonRentalHistory.Name = "buttonRentalHistory";
            this.buttonRentalHistory.Size = new System.Drawing.Size(87, 27);
            this.buttonRentalHistory.TabIndex = 4;
            this.buttonRentalHistory.Text = "Rental History";
            this.buttonRentalHistory.UseVisualStyleBackColor = true;
            this.buttonRentalHistory.Click += new System.EventHandler(this.buttonRentalHistory_Click);
            // 
            // CustomerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 499);
            this.Controls.Add(this.buttonRentalHistory);
            this.Controls.Add(this.groupBoxActiveRentals);
            this.Controls.Add(this.buttonUpdateCreate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CustomerEditForm";
            this.Text = "CustomerEditForm";
            this.Load += new System.EventHandler(this.CustomerEditForm_Load);
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.groupBoxActiveRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveRentals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRegDate;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegDate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdateCreate;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.TextBox textBoxAvatarUrl;
        private System.Windows.Forms.Label labelAvatarUrl;
        private System.Windows.Forms.GroupBox groupBoxActiveRentals;
        private System.Windows.Forms.DataGridView dataGridViewActiveRentals;
        private System.Windows.Forms.Button buttonRentalHistory;
    }
}