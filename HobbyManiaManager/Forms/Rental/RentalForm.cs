using System;
using System.Drawing;
using System.Windows.Forms;
using HobbyManiaManager.Models;

namespace HobbyManiaManager.Forms
{
    public partial class RentalForm : Form
    {
        private readonly CustomersRepository _customersRepository;
        private readonly RentalService _rentalService;
        private readonly Control _parent;

        private Rental _rental;
        private Movie _movie;
        private Customer _customer;

        public RentalForm(Movie movie, Control parent)
        {
            InitializeComponent();
            _customersRepository = CustomersRepository.Instance;
            _rentalService = new RentalService();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            _movie = movie;
            _parent = parent;

            _rental = _rentalService.GetMovieRental(movie.Id);
            if (_rental != null) {
                var c = _customersRepository.GetById(_rental.CustomerId);
                if (c == null) {
                    throw new InvalidOperationException($"No customer found with ID {_rental.CustomerId}.");
                }
                this._customer = c;
            }

            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerStartDate.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {
            pictureBoxMoviePoster.Load(_movie.PosterUrl(200));
            labelMovieTitle.Text = _movie.Title;
            labelMovieTitle.MaximumSize = new Size(300, 0);
            labelMovieTitle.AutoSize = true;

            if (_customer != null)
            {
                LoadCustomer();
                labelId.Text = $"ID: {_customer.Id}";
                this.textBoxId.Visible = false;
                buttonStartEnd.Enabled = true;
            }
            else {
                SelectCustomer();
                labelId.Text = $"ID:";
                var t = _movie.Title.Length > 50 ? _movie.Title.Substring(0, 50) + "..." : _movie.Title;
                Text = $"Rental: {t}";
                buttonStartEnd.Enabled = false;
                this.textBoxId.Visible = true;
            }
            textBoxRentalNotes.Text = _rental?.Notes;

            if (_rental != null)
            {
                buttonStartEnd.Text = "End Rental";
                dateTimePickerStartDate.Value = _rental.StartDate;
                dateTimePickerStartDate.Enabled = false;
            }
            else {
                dateTimePickerEnd.Visible = false;
                labelEndDate.Visible = false;
            }
        }

        private void LoadCustomer()
        {
            var t = _movie.Title.Length > 50 ? _movie.Title.Substring(0, 50) + "..." : _movie.Title;
            Text = $"Rental: {t} from {_customer.Name}({_customer.Id})";

            pictureBoxCustomerAvatar.Load(_customer.Avatar);
            labelCustomerName.Text = _customer.Name;
            labelCustomerName.MaximumSize = new Size(300, 0);
            labelCustomerName.AutoSize = true;
            buttonStartEnd.Enabled = true;
            labelCustomerName.Enabled = true;
        }

        private void groupBoxRental_Enter(object sender, EventArgs e)
        {
            textBoxRentalNotes.ScrollBars = ScrollBars.Vertical;
            textBoxRentalNotes.WordWrap = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var c = int.TryParse(this.textBoxId.Text, out var id) ? TryGetCustomer(id) : null;
            if (c != null)
            {
                this._customer = c;
                LoadCustomer();
            }
            else
            {
                SelectCustomer();
            }
        }

        private Customer TryGetCustomer(int id)
        {
            try
            {
                return _customersRepository.GetById(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void SelectCustomer()
        {
            buttonStartEnd.Enabled = false;
            labelCustomerName.Text = "Select customer";
            labelCustomerName.Enabled = false;
            pictureBoxCustomerAvatar.Load(Customer.UnknownAvatar);
        }

        private void buttonStartEnd_Click(object sender, EventArgs e)
        {
            if (_rental == null)
            {
                // Creating a new rental
                if (_customer == null) {
                    throw new ArgumentException("The customer can not be null.", nameof(_customer));
                }
                if (_movie == null)
                {
                    throw new ArgumentException("The Movie can not be null.", nameof(_movie));
                }

                _rentalService.Rent(_customer, _movie, this.textBoxRentalNotes.Text, this.dateTimePickerStartDate.Value);
                MessageBox.Show($"Rent created for movie: {_movie.Title}.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                // Ending an existing rental
                _rentalService.FinishRental(_customer, _movie, this.textBoxRentalNotes.Text, dateTimePickerEnd.Value);
                MessageBox.Show($"Rent finished for movie: {_movie.Title}.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this._parent?.Refresh();
            this.Dispose();
        }
    }
}
