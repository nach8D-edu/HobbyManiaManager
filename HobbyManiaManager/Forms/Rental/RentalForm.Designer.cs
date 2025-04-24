namespace HobbyManiaManager.Forms
{
    partial class RentalForm
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
            this.groupBoxMovie = new System.Windows.Forms.GroupBox();
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.pictureBoxMoviePoster = new System.Windows.Forms.PictureBox();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.pictureBoxCustomerAvatar = new System.Windows.Forms.PictureBox();
            this.groupBoxRental = new System.Windows.Forms.GroupBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.buttonStartEnd = new System.Windows.Forms.Button();
            this.textBoxRentalNotes = new System.Windows.Forms.TextBox();
            this.groupBoxMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoviePoster)).BeginInit();
            this.groupBoxCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomerAvatar)).BeginInit();
            this.groupBoxRental.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMovie
            // 
            this.groupBoxMovie.Controls.Add(this.labelMovieTitle);
            this.groupBoxMovie.Controls.Add(this.pictureBoxMoviePoster);
            this.groupBoxMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMovie.Location = new System.Drawing.Point(20, 23);
            this.groupBoxMovie.Name = "groupBoxMovie";
            this.groupBoxMovie.Size = new System.Drawing.Size(537, 334);
            this.groupBoxMovie.TabIndex = 0;
            this.groupBoxMovie.TabStop = false;
            this.groupBoxMovie.Text = "Movie";
            // 
            // labelMovieTitle
            // 
            this.labelMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovieTitle.Location = new System.Drawing.Point(222, 26);
            this.labelMovieTitle.MaximumSize = new System.Drawing.Size(0, 299);
            this.labelMovieTitle.MinimumSize = new System.Drawing.Size(309, 0);
            this.labelMovieTitle.Name = "labelMovieTitle";
            this.labelMovieTitle.Size = new System.Drawing.Size(309, 299);
            this.labelMovieTitle.TabIndex = 1;
            this.labelMovieTitle.Text = "Title";
            this.labelMovieTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxMoviePoster
            // 
            this.pictureBoxMoviePoster.Location = new System.Drawing.Point(15, 25);
            this.pictureBoxMoviePoster.Name = "pictureBoxMoviePoster";
            this.pictureBoxMoviePoster.Size = new System.Drawing.Size(200, 300);
            this.pictureBoxMoviePoster.TabIndex = 0;
            this.pictureBoxMoviePoster.TabStop = false;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.labelId);
            this.groupBoxCustomer.Controls.Add(this.textBoxId);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerName);
            this.groupBoxCustomer.Controls.Add(this.pictureBoxCustomerAvatar);
            this.groupBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomer.Location = new System.Drawing.Point(570, 23);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(537, 334);
            this.groupBoxCustomer.TabIndex = 2;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Customer";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(231, 32);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(46, 26);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID: ";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(283, 29);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(135, 32);
            this.textBoxId.TabIndex = 2;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(221, 88);
            this.labelCustomerName.MaximumSize = new System.Drawing.Size(309, 137);
            this.labelCustomerName.MinimumSize = new System.Drawing.Size(309, 137);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(309, 137);
            this.labelCustomerName.TabIndex = 1;
            this.labelCustomerName.Text = "Name";
            // 
            // pictureBoxCustomerAvatar
            // 
            this.pictureBoxCustomerAvatar.Location = new System.Drawing.Point(15, 25);
            this.pictureBoxCustomerAvatar.Name = "pictureBoxCustomerAvatar";
            this.pictureBoxCustomerAvatar.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxCustomerAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCustomerAvatar.TabIndex = 0;
            this.pictureBoxCustomerAvatar.TabStop = false;
            // 
            // groupBoxRental
            // 
            this.groupBoxRental.Controls.Add(this.labelEndDate);
            this.groupBoxRental.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxRental.Controls.Add(this.labelStartDate);
            this.groupBoxRental.Controls.Add(this.dateTimePickerStartDate);
            this.groupBoxRental.Controls.Add(this.buttonStartEnd);
            this.groupBoxRental.Controls.Add(this.textBoxRentalNotes);
            this.groupBoxRental.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRental.Location = new System.Drawing.Point(22, 366);
            this.groupBoxRental.Name = "groupBoxRental";
            this.groupBoxRental.Size = new System.Drawing.Size(1084, 142);
            this.groupBoxRental.TabIndex = 3;
            this.groupBoxRental.TabStop = false;
            this.groupBoxRental.Text = "Rental";
            this.groupBoxRental.Enter += new System.EventHandler(this.groupBoxRental_Enter);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(558, 85);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(43, 21);
            this.labelEndDate.TabIndex = 5;
            this.labelEndDate.Text = "End: ";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(614, 82);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(211, 28);
            this.dateTimePickerEnd.TabIndex = 4;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(558, 50);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(50, 21);
            this.labelStartDate.TabIndex = 3;
            this.labelStartDate.Text = "Start: ";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(614, 47);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(211, 28);
            this.dateTimePickerStartDate.TabIndex = 2;
            // 
            // buttonStartEnd
            // 
            this.buttonStartEnd.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartEnd.Location = new System.Drawing.Point(894, 27);
            this.buttonStartEnd.Name = "buttonStartEnd";
            this.buttonStartEnd.Size = new System.Drawing.Size(184, 100);
            this.buttonStartEnd.TabIndex = 1;
            this.buttonStartEnd.Text = "Start";
            this.buttonStartEnd.UseVisualStyleBackColor = true;
            this.buttonStartEnd.Click += new System.EventHandler(this.buttonStartEnd_Click);
            // 
            // textBoxRentalNotes
            // 
            this.textBoxRentalNotes.Location = new System.Drawing.Point(13, 27);
            this.textBoxRentalNotes.Multiline = true;
            this.textBoxRentalNotes.Name = "textBoxRentalNotes";
            this.textBoxRentalNotes.Size = new System.Drawing.Size(522, 100);
            this.textBoxRentalNotes.TabIndex = 0;
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 520);
            this.Controls.Add(this.groupBoxRental);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.groupBoxMovie);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentalForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RentalForm_Load);
            this.groupBoxMovie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoviePoster)).EndInit();
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomerAvatar)).EndInit();
            this.groupBoxRental.ResumeLayout(false);
            this.groupBoxRental.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMovie;
        private System.Windows.Forms.PictureBox pictureBoxMoviePoster;
        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.PictureBox pictureBoxCustomerAvatar;
        private System.Windows.Forms.GroupBox groupBoxRental;
        private System.Windows.Forms.TextBox textBoxRentalNotes;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonStartEnd;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
    }
}