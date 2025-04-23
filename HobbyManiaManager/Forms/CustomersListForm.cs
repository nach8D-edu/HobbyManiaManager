using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HobbyManiaManager.Forms
{
    public partial class CustomersListForm : Form
    {
        private CustomersRepository repository;
        public CustomersListForm()
        {
            InitializeComponent();
            this.repository = CustomersRepository.Instance;
        }

        private void CustomersListForm_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.None;
            this.Font = SystemFonts.DefaultFont;
            LoadDatagrid();
        }

        private void LoadDatagrid()
        {
            this.dataGridViewCustomersList.DataSource = repository.GetAll().ToList();
            this.dataGridViewCustomersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomersList.ReadOnly = true;
        }

        private void dataGridViewCustomersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewCustomersList.Rows[e.RowIndex];
                var id = (int)selectedRow.Cells[0].Value;
                var customer = repository.GetById(id);
                var customerForm = new CustomerEditForm(customer);
                customerForm.ShowDialog();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.dataGridViewCustomersList.DataSource = repository.GetAll().Where(c => c.Id.ToString() == textBoxId.Text).ToList();
            this.dataGridViewCustomersList.Refresh();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text)) {
                this.dataGridViewCustomersList.DataSource = repository.GetAll().ToList();
                this.dataGridViewCustomersList.Refresh();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var createCustomer = new CustomerEditForm(null, this);
            createCustomer.ShowDialog();
        }

        public override void Refresh()
        {
            base.Refresh();
            LoadDatagrid();
        }
    }
}
