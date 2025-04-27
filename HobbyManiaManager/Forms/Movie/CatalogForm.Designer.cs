namespace HobbyManiaManager
{
    partial class CatalogForm
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
            this.dataGridViewMoviesList = new System.Windows.Forms.DataGridView();
            this.movieUserControl = new HobbyManiaManager.MovieUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoviesList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMoviesList
            // 
            this.dataGridViewMoviesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMoviesList.Location = new System.Drawing.Point(14, 325);
            this.dataGridViewMoviesList.Name = "dataGridViewMoviesList";
            this.dataGridViewMoviesList.Size = new System.Drawing.Size(907, 268);
            this.dataGridViewMoviesList.TabIndex = 1;
            this.dataGridViewMoviesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMoviesList_CellContentClick);
            this.dataGridViewMoviesList.SelectionChanged += new System.EventHandler(this.dataGridViewMoviesList_SelectionChanged);
            // 
            // movieUserControl
            // 
            this.movieUserControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movieUserControl.Location = new System.Drawing.Point(14, 12);
            this.movieUserControl.Name = "movieUserControl";
            this.movieUserControl.Size = new System.Drawing.Size(907, 307);
            this.movieUserControl.TabIndex = 0;
            // 
            // CatalogForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(937, 606);
            this.Controls.Add(this.dataGridViewMoviesList);
            this.Controls.Add(this.movieUserControl);
            this.Name = "CatalogForm";
            this.Text = "Movies Catalog";
            this.Load += new System.EventHandler(this.CatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoviesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MovieUserControl movieUserControl;
        private System.Windows.Forms.DataGridView dataGridViewMoviesList;
    }
}