namespace HobbyManiaManager
{
    partial class MainForm
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelMoviesCounter = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCatalog = new System.Windows.Forms.TabPage();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMoviesCounter
            // 
            this.labelMoviesCounter.AutoSize = true;
            this.labelMoviesCounter.Location = new System.Drawing.Point(12, 678);
            this.labelMoviesCounter.Name = "labelMoviesCounter";
            this.labelMoviesCounter.Size = new System.Drawing.Size(35, 13);
            this.labelMoviesCounter.TabIndex = 0;
            this.labelMoviesCounter.Text = "label1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "movie_icon.png");
            this.imageList1.Images.SetKeyName(1, "customers_icon.png");
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageCatalog);
            this.tabControlMain.Controls.Add(this.tabPageCustomers);
            this.tabControlMain.ImageList = this.imageList1;
            this.tabControlMain.Location = new System.Drawing.Point(12, 37);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(943, 638);
            this.tabControlMain.TabIndex = 4;
            // 
            // tabPageCatalog
            // 
            this.tabPageCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCatalog.ImageIndex = 0;
            this.tabPageCatalog.Location = new System.Drawing.Point(4, 23);
            this.tabPageCatalog.Name = "tabPageCatalog";
            this.tabPageCatalog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCatalog.Size = new System.Drawing.Size(935, 611);
            this.tabPageCatalog.TabIndex = 0;
            this.tabPageCatalog.Text = "Catalog";
            this.tabPageCatalog.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.ImageIndex = 1;
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 23);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomers.Size = new System.Drawing.Size(935, 611);
            this.tabPageCustomers.TabIndex = 1;
            this.tabPageCustomers.Text = "Customers";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(879, 678);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 705);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.labelMoviesCounter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hobby Mania Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMoviesCounter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCatalog;
        private System.Windows.Forms.TabPage tabPageCustomers;
        private System.Windows.Forms.Button buttonExit;
    }
}

