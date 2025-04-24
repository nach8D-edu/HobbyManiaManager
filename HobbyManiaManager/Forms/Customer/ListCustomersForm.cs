using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HobbyManiaManager.Forms
{
    public partial class ListCustomersForm : Form
    {
        private readonly CustomersRepository _repository;

        public ListCustomersForm()
        {
            InitializeComponent();
            _repository = CustomersRepository.Instance;
        }

        private void CustomersListForm_Load(object sender, EventArgs e)
        {
            AutoScaleMode = AutoScaleMode.None;
            Font = SystemFonts.DefaultFont;
            LoadCustomersGrid();
        }

        private void LoadCustomersGrid()
        {
            dataGridViewCustomersList.DataSource = _repository.GetAll().ToList();
            dataGridViewCustomersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCustomersList.ReadOnly = true;
        }

        private void dataGridViewCustomersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewCustomersList.Rows[e.RowIndex];
                var id = (int)selectedRow.Cells[0].Value;
                var customer = _repository.GetById(id);
                var customerForm = new EditCustomerForm(this, customer);
                customerForm.ShowDialog();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewCustomersList.DataSource = _repository.GetAll().Where(c => c.Id.ToString() == textBoxId.Text).ToList();
            dataGridViewCustomersList.Refresh();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                dataGridViewCustomersList.DataSource = _repository.GetAll().ToList();
                dataGridViewCustomersList.Refresh();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var createCustomer = new EditCustomerForm(this);
            createCustomer.ShowDialog();
        }

        public override void Refresh()
        {
            base.Refresh();
            LoadCustomersGrid();
        }
    }
}
