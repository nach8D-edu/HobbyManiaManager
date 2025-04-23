using System;
using System.Drawing;
using System.Windows.Forms;
using HobbyManiaManager.Models;

namespace HobbyManiaManager.Forms
{
    public partial class RentalForm : Form
    {
        private CustomersRepository _customersRepository;
        private RentalService _rentalService;
        private Rental _rental;
        private Movie _movie;
        private Customer _customer;
        private Control _parent;

        public RentalForm(Movie movie, Control parent)
        {
            InitializeComponent();
            this._customersRepository = CustomersRepository.Instance;
            this._rentalService = new RentalService();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            this._movie = movie;
            this._parent = parent;

            this._rental = _rentalService.GetMovieRental(movie.Id);
            if (_rental != null) {
                var c = _customersRepository.GetById(_rental.CustomerId);
                if (c == null) { 
                    // exception
                }
                this._customer = c;
            }

            this.dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerStartDate.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {
            this.pictureBoxMoviePoster.Load(_movie.PosterUrl(200));
            this.labelMovieTitle.Text = _movie.Title;
            this.labelMovieTitle.MaximumSize = new Size(300, 0);
            this.labelMovieTitle.AutoSize = true;

            if (_customer != null)
            {
                LoadCustomer();
                this.textBoxId.Enabled = false;
            }
            else {
                SelectCustomer();
                var t = _movie.Title.Length > 50 ? _movie.Title.Substring(0, 50) + "..." : _movie.Title;
                this.Text = $"Rental: {t}";
                this.buttonStartEnd.Enabled = false;
            }
            this.textBoxRentalNotes.Text = _rental?.Notes;

            if (_rental != null)
            {
                this.buttonStartEnd.Text = "End Rental";
                this.dateTimePickerStartDate.Value = _rental.StartDate;
                this.dateTimePickerStartDate.Enabled = false;
            }
            else {
                this.dateTimePickerEnd.Visible = false;
                this.labelEndDate.Visible = false;
            }
        }

        private void LoadCustomer()
        {
            var t = _movie.Title.Length > 50 ? _movie.Title.Substring(0, 50) + "..." : _movie.Title;
            this.Text = $"Rental: {t} from {_customer.Name}({_customer.Id})";
            this.pictureBoxCustomerAvatar.Load(_customer.Avatar);
            this.labelCustomerName.Text = _customer.Name;
            this.labelCustomerName.MaximumSize = new Size(300, 0);
            this.labelCustomerName.AutoSize = true;
            this.buttonStartEnd.Enabled = true;
            this.textBoxId.Text = _customer.Id.ToString();
            this.labelCustomerName.Enabled = true;
        }

        private void groupBoxRental_Enter(object sender, EventArgs e)
        {
            this.textBoxRentalNotes.ScrollBars = ScrollBars.Vertical;
            this.textBoxRentalNotes.WordWrap = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var c = int.TryParse(this.textBoxId.Text, out var id)
                ? _customersRepository.GetById(id)
                : null;
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

        private void SelectCustomer()
        {
            this.buttonStartEnd.Enabled = false;
            this.labelCustomerName.Text = "Select customer";
            this.labelCustomerName.Enabled = false;
            this.pictureBoxCustomerAvatar.Load(Customer.UnknownAvatar);
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
                _rentalService.FinishRental(_customer, _movie, this.textBoxRentalNotes.Text);
                MessageBox.Show($"Rent finished for movie: {_movie.Title}.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this._parent?.Refresh();
            this.Dispose();
        }
    }
}
