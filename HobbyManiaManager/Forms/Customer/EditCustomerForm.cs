using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HobbyManiaManager.Models;
using HobbyManiaManager.Repositories;
using HobbyManiaManager.ViewModels;

namespace HobbyManiaManager.Forms
{
    public partial class EditCustomerForm : Form
    {
        private static string _defaultAvatarUrlTemplate = "https://ui-avatars.com/api/?name={0}&size=150";

        private readonly CustomersRepository _customersRepository;
        private readonly MoviesRepository _moviesRepository;
        private readonly RentalsRepository _rentalsRepository;
        private readonly Form _parent;

        private Customer _customer;
        private string _loadedAvatarUrl;

        public EditCustomerForm(Form parent, Customer customer = null)
        {
            InitializeComponent();
            _customer = customer;
            textBoxId.Enabled = false;
            _customersRepository = CustomersRepository.Instance;
            _rentalsRepository = RentalsRepository.Instance;
            _moviesRepository = MoviesRepository.Instance;
            _parent = parent;
        }

        private void CustomerEditForm_Load(object sender, EventArgs e)
        {
            if (_customer == null)
            {
                CreateCustomerLoad();
            }
            else
            {
                UpdateCustomerLoad();
            }
            dateTimePickerRegDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerRegDate.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void UpdateCustomerLoad()
        {
            buttonUpdateCreate.Text = "Update";
            textBoxId.Text = _customer.Id.ToString();
            textBoxName.Text = _customer.Name;
            textBoxEmail.Text = _customer.Email;
            textBoxPhone.Text = _customer.PhoneNumber;
            dateTimePickerRegDate.Value = _customer.RegistrationDate;
            pictureBoxAvatar.Load(_customer.Avatar);
            textBoxAvatarUrl.Text = _customer.Avatar;
            Text = $"Customer: {_customer.Name}({_customer.Id})";

            LoadRentalsDataGrid();
        }

        private void LoadRentalsDataGrid()
        {
            this.dataGridViewActiveRentals.DataSource = _rentalsRepository.GetCustomerRentals(_customer.Id)
                .Select(c => BuildRentalViewModel(c))
                .ToList();
            dataGridViewActiveRentals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewActiveRentals.ReadOnly = true;
            dataGridViewActiveRentals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewActiveRentals.Columns["Rental"].Visible = false;
            dataGridViewActiveRentals.Columns["EndDate"].Visible = false;
        }

        private RentalDataGridViewModel BuildRentalViewModel(Rental r)
        {
            var m = _moviesRepository.GetById(r.MovieId);
            if (m == null)
            {
                throw new ArgumentException("The given Movie does not exist.", nameof(r));
            }
            return new RentalDataGridViewModel(m, r);
        }

        private void CreateCustomerLoad()
        {
            textBoxId.Text = Customer.NextCustomerId.ToString();
            dateTimePickerRegDate.Value = DateTime.Now;
            Text = "Create New Customer";

            string defaultAvatarUrl = BuildDefaultAvatarUrl();
            pictureBoxAvatar.Load(defaultAvatarUrl);
            _loadedAvatarUrl = defaultAvatarUrl;
        }

        private void buttonUpdateCreate_Click(object sender, EventArgs e)
        {
            if (_customer == null)
            {
                CreateCustomer();
                MessageBox.Show("The client has been created successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateCustomer();
                MessageBox.Show("The client has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBoxAvatarUrl.Text = _loadedAvatarUrl;
            _parent?.Refresh();
            Dispose();
        }

        private void CreateCustomer()
        {
            var newCustomer = GetFormCustomer();
            _customersRepository.Add(newCustomer);
            buttonUpdateCreate.Text = "Update";
        }

        private void UpdateCustomer()
        {
            var updatedCustomer = GetFormCustomer(); ;
            _customersRepository.Update(updatedCustomer);
        }

        private Customer GetFormCustomer()
        {
            return new Customer
            {
                Id = int.Parse(textBoxId.Text),
                Name = textBoxName.Text,
                Email = textBoxEmail.Text,
                PhoneNumber = textBoxPhone.Text,
                RegistrationDate = dateTimePickerRegDate.Value,
                Avatar = _loadedAvatarUrl
            };
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            RefreshDefaultProfilePic();
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            RefreshDefaultProfilePic();
        }

        private void textBoxAvatarUrl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBoxAvatar.Load(textBoxAvatarUrl.Text);
                _loadedAvatarUrl = textBoxAvatarUrl.Text;
            }
            catch (Exception ex)
            {
                string defaultAvatarUrl = BuildDefaultAvatarUrl();
                pictureBoxAvatar.Load(defaultAvatarUrl);
                _loadedAvatarUrl = defaultAvatarUrl;
                Console.WriteLine("Error loading image, using default: " + _loadedAvatarUrl);
            }
        }

        private void RefreshDefaultProfilePic()
        {
            if (ShouldRefreshAvatar())
            {
                string defaultAvatarUrl = BuildDefaultAvatarUrl();
                try
                {
                    pictureBoxAvatar.Load(defaultAvatarUrl);
                    _loadedAvatarUrl = defaultAvatarUrl;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading avatar: " + ex.Message);
                }
            }
        }

        private bool ShouldRefreshAvatar()
        {
            return (string.IsNullOrEmpty(_loadedAvatarUrl) || string.IsNullOrEmpty(textBoxAvatarUrl.Text)) &&
                   (textBoxName.Text.Length % 5 == 0 || textBoxName.Text.Length == 1);
        }

        private string BuildDefaultAvatarUrl()
        {
            var name = string.IsNullOrEmpty(textBoxName.Text.Trim()) ?
                "C" : textBoxName.Text.Replace(" ", "+");
            var defaultAvatarUrl = string.Format(_defaultAvatarUrlTemplate, Uri.EscapeDataString(name));
            return defaultAvatarUrl;
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridViewActiveRentals.Rows.Count == 0)
            {
                string mensaje = "No data to show.";
                Font font = new Font("Segoe UI", 12, FontStyle.Italic);
                SizeF textSize = e.Graphics.MeasureString(mensaje, font);
                float x = (dataGridViewActiveRentals.Width - textSize.Width) / 2;
                float y = (dataGridViewActiveRentals.Height - textSize.Height) / 2;
                e.Graphics.DrawString(mensaje, font, Brushes.Gray, x, y);
            }
        }

        private void dataGridViewActiveRentals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewActiveRentals.Rows[e.RowIndex];
                var r = (Rental)selectedRow.Cells["Rental"].Value;
                var m = _moviesRepository.GetById(r.MovieId);
                var customerForm = new RentalForm(m, this);
                customerForm.ShowDialog();
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            LoadRentalsDataGrid();
            _customer = _customersRepository.GetById(_customer.Id);
        }

        private void buttonRentalHistory_Click(object sender, EventArgs e)
        {
            var rentalHistoryForm = new RentalHistoryForm(_customer);
            rentalHistoryForm.ShowDialog();
        }
    }
}
