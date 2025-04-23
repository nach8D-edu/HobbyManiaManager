namespace HobbyManiaManager.Forms
{
    partial class CustomersListForm
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
            this.dataGridViewCustomersList = new System.Windows.Forms.DataGridView();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomersList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomersList
            // 
            this.dataGridViewCustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomersList.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewCustomersList.Name = "dataGridViewCustomersList";
            this.dataGridViewCustomersList.Size = new System.Drawing.Size(913, 541);
            this.dataGridViewCustomersList.TabIndex = 0;
            this.dataGridViewCustomersList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomersList_CellDoubleClick);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(17, 26);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Id:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(43, 26);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 2;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(150, 26);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(816, 26);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(109, 23);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Create Customer";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // CustomersListForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(937, 606);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.dataGridViewCustomersList);
            this.Name = "CustomersListForm";
            this.Text = "CustomersListForm";
            this.Load += new System.EventHandler(this.CustomersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomersList;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCreate;
    }
}