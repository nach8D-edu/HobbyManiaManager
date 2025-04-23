using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HobbyManiaManager.Models;
using HobbyManiaManager.Repositories;
using HobbyManiaManager.ViewModels;

namespace HobbyManiaManager.Forms
{
    public partial class CustomerEditForm : Form
    {
        private static string defaultAvatar = "https://ui-avatars.com/api/?name={0}&size=150";

        private Customer customer;
        private CustomersRepository repository;
        private MoviesRepository movieRepository;
        private RentalsRepository rentalsRepository;
        private string loadedAvatarUrl;
        private Form parent;

        public CustomerEditForm(Form parent, Customer customer = null)
        {
            InitializeComponent();
            this.customer = customer;
            this.textBoxId.Enabled = false;
            this.repository = CustomersRepository.Instance;
            this.rentalsRepository = RentalsRepository.Instance;
            this.movieRepository = MoviesRepository.Instance;
            this.parent = parent;
        }

        private void CustomerEditForm_Load(object sender, EventArgs e)
        {
            if (customer == null) {
                CreateCustomerLoad();
            }
            else
            {
                UpdateCustomerLoad();
            }
            this.dateTimePickerRegDate.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerRegDate.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void UpdateCustomerLoad()
        {
            this.buttonUpdateCreate.Text = "Update";
            this.textBoxId.Text = customer.Id.ToString();
            this.textBoxName.Text = customer.Name;
            this.textBoxEmail.Text = customer.Email;
            this.textBoxPhone.Text = customer.PhoneNumber;
            this.dateTimePickerRegDate.Value = customer.RegistrationDate;
            this.pictureBoxAvatar.Load(customer.Avatar);
            this.textBoxAvatarUrl.Text = customer.Avatar;
            this.Text = $"Customer: {customer.Name}({customer.Id})";

            LoadRentalsDataGrid();
        }

        private void LoadRentalsDataGrid()
        {
            this.dataGridViewActiveRentals.DataSource = rentalsRepository.GetCustomerRentals(customer.Id)
                .Select(c => BuildRentalViewModel(c))
                .ToList();
            this.dataGridViewActiveRentals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActiveRentals.ReadOnly = true;
            this.dataGridViewActiveRentals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActiveRentals.Columns["Rental"].Visible = false;
            this.dataGridViewActiveRentals.Columns["EndDate"].Visible = false;

        }

        private RentalDataGridViewModel BuildRentalViewModel(Rental r) {
            var m = movieRepository.GetById(r.MovieId);
            if (m == null) {
                throw new ArgumentException("The given Movie does not exist.", nameof(r));
            }
            return new RentalDataGridViewModel(m,r);
        }

        private void CreateCustomerLoad()
        {
            this.textBoxId.Text = Customer.NextCustomerId.ToString();
            this.dateTimePickerRegDate.Value = DateTime.Now;
            this.Text = "Create New Customer";
            string defaultAvatarUrl = BuildDefaultAvatarUrl();
            pictureBoxAvatar.Load(defaultAvatarUrl);
            loadedAvatarUrl = defaultAvatarUrl;
        }

        private void buttonUpdateCreate_Click(object sender, EventArgs e)
        {
            if (customer == null)
            {
                CreateCustomer();
                MessageBox.Show("The client has been created successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                UpdateCustomer();
                MessageBox.Show("The client has been updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.textBoxAvatarUrl.Text = loadedAvatarUrl;
            this.parent?.Refresh();
            this.Dispose();
        }

        private void CreateCustomer()
        {
            Customer newCustomer = GetFormCustomer();
            this.repository.Add(newCustomer);
            this.buttonUpdateCreate.Text = "Update";
        }

        private void UpdateCustomer()
        {
            var updatedCustomer = GetFormCustomer(); ;
            this.repository.Update(updatedCustomer);
        }

        private Customer GetFormCustomer()
        {
            return new Customer
            {
                Id = int.Parse(this.textBoxId.Text),
                Name = this.textBoxName.Text,
                Email = this.textBoxEmail.Text,
                PhoneNumber = this.textBoxPhone.Text,
                RegistrationDate = this.dateTimePickerRegDate.Value,
                Avatar = loadedAvatarUrl
            };
        }

        private string BuildDefaultAvatarUrl()
        {
            var name = string.IsNullOrEmpty(textBoxName.Text.Trim()) ?
                "C" : this.textBoxName.Text.Replace(" ", "+");
            var defaultAvatarUrl = string.Format(defaultAvatar, name);
            return defaultAvatarUrl;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            refreshDefaultProfilePic();
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            refreshDefaultProfilePic();
        }
        private void textBoxAvatarUrl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                    pictureBoxAvatar.Load(textBoxAvatarUrl.Text);
                    loadedAvatarUrl = textBoxAvatarUrl.Text;
            }
            catch (Exception ex)
            {
                string defaultAvatarUrl = BuildDefaultAvatarUrl();
                pictureBoxAvatar.Load(defaultAvatarUrl);
                loadedAvatarUrl = defaultAvatarUrl;
                Console.WriteLine("Error loading image, using default: " + loadedAvatarUrl);
            }
        }

        private void refreshDefaultProfilePic()
        {
            if ((string.IsNullOrEmpty(loadedAvatarUrl) || string.IsNullOrEmpty(textBoxAvatarUrl.Text)) 
                && (textBoxName.Text.Length % 5 == 0 || textBoxName.Text.Length == 1))
            {
                string defaultAvatarUrl = BuildDefaultAvatarUrl();
                try
                {
                    pictureBoxAvatar.Load(defaultAvatarUrl);
                    loadedAvatarUrl = defaultAvatarUrl;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading avatar: " + ex.Message);
                }
            }
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            if (this.dataGridViewActiveRentals.Rows.Count == 0)
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
                var m = movieRepository.GetById(r.MovieId);
                var customerForm = new RentalForm(m, this);
                customerForm.ShowDialog();
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            LoadRentalsDataGrid();
            customer = repository.GetById(customer.Id);
        }

        private void buttonRentalHistory_Click(object sender, EventArgs e)
        {
            var rentalHistoryForm = new RentalHistoryForm(customer);
            rentalHistoryForm.ShowDialog();
        }
    }
}
