namespace HobbyManiaManager
{
    partial class MovieUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieUserControl));
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
            this.labelOriginalTitle = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelOverview = new System.Windows.Forms.Label();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.pictureBoxAvailable = new System.Windows.Forms.PictureBox();
            this.buttonStartEndRent = new System.Windows.Forms.Button();
            this.circularProgressBarVotes = new CircularProgressBar.CircularProgressBar();
            this.labelVotesCount = new System.Windows.Forms.Label();
            this.labelGenres = new System.Windows.Forms.Label();
            this.btnImdb = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(279, 4);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.MaximumSize = new System.Drawing.Size(800, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(800, 0);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // pictureBoxPoster
            // 
            this.pictureBoxPoster.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxPoster.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(267, 369);
            this.pictureBoxPoster.TabIndex = 1;
            this.pictureBoxPoster.TabStop = false;
            // 
            // labelOriginalTitle
            // 
            this.labelOriginalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOriginalTitle.Location = new System.Drawing.Point(283, 66);
            this.labelOriginalTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOriginalTitle.MaximumSize = new System.Drawing.Size(800, 0);
            this.labelOriginalTitle.Name = "labelOriginalTitle";
            this.labelOriginalTitle.Size = new System.Drawing.Size(800, 0);
            this.labelOriginalTitle.TabIndex = 2;
            this.labelOriginalTitle.Text = "Original Title";
            // 
            // labelId
            // 
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(1089, 4);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelId.Size = new System.Drawing.Size(120, 32);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID";
            // 
            // labelOverview
            // 
            this.labelOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverview.Location = new System.Drawing.Point(404, 108);
            this.labelOverview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOverview.MaximumSize = new System.Drawing.Size(800, 0);
            this.labelOverview.MinimumSize = new System.Drawing.Size(800, 22);
            this.labelOverview.Name = "labelOverview";
            this.labelOverview.Size = new System.Drawing.Size(800, 22);
            this.labelOverview.TabIndex = 4;
            this.labelOverview.Text = "Overview";
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailable.Location = new System.Drawing.Point(303, 346);
            this.labelAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(133, 25);
            this.labelAvailable.TabIndex = 6;
            this.labelAvailable.Text = "labelAvailable";
            // 
            // pictureBoxAvailable
            // 
            this.pictureBoxAvailable.Location = new System.Drawing.Point(283, 351);
            this.pictureBoxAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAvailable.Name = "pictureBoxAvailable";
            this.pictureBoxAvailable.Size = new System.Drawing.Size(16, 15);
            this.pictureBoxAvailable.TabIndex = 7;
            this.pictureBoxAvailable.TabStop = false;
            // 
            // buttonStartEndRent
            // 
            this.buttonStartEndRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartEndRent.Location = new System.Drawing.Point(977, 326);
            this.buttonStartEndRent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartEndRent.Name = "buttonStartEndRent";
            this.buttonStartEndRent.Size = new System.Drawing.Size(228, 47);
            this.buttonStartEndRent.TabIndex = 8;
            this.buttonStartEndRent.Text = "Start Rent";
            this.buttonStartEndRent.UseVisualStyleBackColor = true;
            this.buttonStartEndRent.Click += new System.EventHandler(this.buttonStartEndRent_Click);
            // 
            // circularProgressBarVotes
            // 
            this.circularProgressBarVotes.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarVotes.AnimationSpeed = 500;
            this.circularProgressBarVotes.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarVotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarVotes.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarVotes.InnerMargin = 2;
            this.circularProgressBarVotes.InnerWidth = -1;
            this.circularProgressBarVotes.Location = new System.Drawing.Point(289, 108);
            this.circularProgressBarVotes.Margin = new System.Windows.Forms.Padding(4);
            this.circularProgressBarVotes.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarVotes.Name = "circularProgressBarVotes";
            this.circularProgressBarVotes.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarVotes.OuterMargin = -25;
            this.circularProgressBarVotes.OuterWidth = 25;
            this.circularProgressBarVotes.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarVotes.ProgressWidth = 7;
            this.circularProgressBarVotes.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.circularProgressBarVotes.Size = new System.Drawing.Size(107, 98);
            this.circularProgressBarVotes.StartAngle = 270;
            this.circularProgressBarVotes.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarVotes.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBarVotes.SubscriptText = "";
            this.circularProgressBarVotes.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarVotes.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBarVotes.SuperscriptText = "";
            this.circularProgressBarVotes.TabIndex = 9;
            this.circularProgressBarVotes.Text = "52";
            this.circularProgressBarVotes.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBarVotes.Value = 10;
            // 
            // labelVotesCount
            // 
            this.labelVotesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVotesCount.Location = new System.Drawing.Point(285, 210);
            this.labelVotesCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVotesCount.Name = "labelVotesCount";
            this.labelVotesCount.Size = new System.Drawing.Size(107, 28);
            this.labelVotesCount.TabIndex = 10;
            this.labelVotesCount.Text = "Votes Count";
            this.labelVotesCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelGenres
            // 
            this.labelGenres.AutoSize = true;
            this.labelGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelGenres.Location = new System.Drawing.Point(284, 74);
            this.labelGenres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGenres.Name = "labelGenres";
            this.labelGenres.Size = new System.Drawing.Size(64, 20);
            this.labelGenres.TabIndex = 11;
            this.labelGenres.Text = "Genres";
            // 
            // btnImdb
            // 
            this.btnImdb.ImageIndex = 0;
            this.btnImdb.ImageList = this.imageList1;
            this.btnImdb.Location = new System.Drawing.Point(1093, 267);
            this.btnImdb.Name = "btnImdb";
            this.btnImdb.Size = new System.Drawing.Size(111, 52);
            this.btnImdb.TabIndex = 14;
            this.btnImdb.UseVisualStyleBackColor = true;
            this.btnImdb.Click += new System.EventHandler(this.btnImdb_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "imdb.PNG");
            // 
            // MovieUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnImdb);
            this.Controls.Add(this.labelGenres);
            this.Controls.Add(this.labelVotesCount);
            this.Controls.Add(this.circularProgressBarVotes);
            this.Controls.Add(this.buttonStartEndRent);
            this.Controls.Add(this.pictureBoxAvailable);
            this.Controls.Add(this.labelAvailable);
            this.Controls.Add(this.labelOverview);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelOriginalTitle);
            this.Controls.Add(this.pictureBoxPoster);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MovieUserControl";
            this.Size = new System.Drawing.Size(1209, 378);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvailable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxPoster;
        private System.Windows.Forms.Label labelOriginalTitle;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelOverview;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.PictureBox pictureBoxAvailable;
        private System.Windows.Forms.Button buttonStartEndRent;
        private CircularProgressBar.CircularProgressBar circularProgressBarVotes;
        private System.Windows.Forms.Label labelVotesCount;
        private System.Windows.Forms.Label labelGenres;
        private System.Windows.Forms.Button btnImdb;
        private System.Windows.Forms.ImageList imageList1;
    }
}
