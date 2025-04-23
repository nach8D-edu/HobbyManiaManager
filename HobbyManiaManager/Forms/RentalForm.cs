using System;
using System.Drawing;
using System.Windows.Forms;
using HobbyManiaManager.Models;

namespace HobbyManiaManager.Forms
{
    public partial class RentalForm : Form
    {
        private CustomersRepository customersRepository;
        private RentalService rentalService;
        private Rental rental;
        private Movie movie;
        private Customer customer;
        private UserControl parent;

        public RentalForm(Movie movie, UserControl parent)
        {
            InitializeComponent();
            this.customersRepository = CustomersRepository.Instance;
            this.rentalService = new RentalService();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            this.movie = movie;
            this.parent = parent;

            this.rental = rentalService.GetMovieRental(movie.Id);
            if (rental != null) {
                var c = customersRepository.GetById(rental.CustomerId);
                if (c == null) { 
                    // exception
                }
                this.customer = c;
            }

            this.dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerStartDate.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {
            this.pictureBoxMoviePoster.Load(movie.PosterUrl(200));
            this.labelMovieTitle.Text = movie.Title;
            this.labelMovieTitle.MaximumSize = new Size(300, 0);
            this.labelMovieTitle.AutoSize = true;

            if (customer != null)
            {
                LoadCustomer();
                this.textBoxId.Enabled = false;
            }
            else {
                SelectCustomer();
                var t = movie.Title.Length > 50 ? movie.Title.Substring(0, 50) + "..." : movie.Title;
                this.Text = $"Rental: {t}";
                this.buttonStartEnd.Enabled = false;
            }
            this.textBoxRentalNotes.Text = rental?.Notes;

            if (rental != null)
            {
                this.buttonStartEnd.Text = "End Rental";
                this.dateTimePickerStartDate.Value = rental.StartDate;
                this.dateTimePickerStartDate.Enabled = false;
            }
            else {
                this.dateTimePickerEnd.Visible = false;
                this.labelEndDate.Visible = false;
            }

        }

        private void LoadCustomer()
        {
            var t = movie.Title.Length > 50 ? movie.Title.Substring(0, 50) + "..." : movie.Title;
            this.Text = $"Rental: {t} from {customer.Name}({customer.Id})";
            this.pictureBoxCustomerAvatar.Load(customer.Avatar);
            this.labelCustomerName.Text = customer.Name;
            this.labelCustomerName.MaximumSize = new Size(300, 0);
            this.labelCustomerName.AutoSize = true;
            this.buttonStartEnd.Enabled = true;
            this.textBoxId.Text = customer.Id.ToString();
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
                ? customersRepository.GetById(id)
                : null;
            if (c != null)
            {
                this.customer = c;
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
            if (rental == null)
            {
                if (customer == null || movie == null) { 
                    // Exception
                }
                // Starting new rental
                rentalService.Rent(customer, movie, this.textBoxRentalNotes.Text);
                MessageBox.Show("Rent created.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //TODO hacer algo con el start date
            }
            else {
                // Ending an existing rental
                rentalService.FinishRental(customer, movie, this.textBoxRentalNotes.Text);
                MessageBox.Show("Rent finished.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //TODO hacer algo con las fechas
            }
            this.parent?.Refresh();
            this.Dispose();
        }
    }
}
