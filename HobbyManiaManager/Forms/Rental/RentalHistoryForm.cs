using System;
using System.Linq;
using System.Windows.Forms;
using HobbyManiaManager.Models;
using HobbyManiaManager.ViewModels;

namespace HobbyManiaManager.Forms
{
    public partial class RentalHistoryForm : Form
    {
        private readonly MoviesRepository _movieRepository;

        public RentalHistoryForm(Customer customer)
        {
            InitializeComponent();
            _movieRepository = MoviesRepository.Instance;
            Text = $"Rental history of: {customer.Id}-{customer.Name}";

            SetupRentalHistoryGrid(customer);
        }

        private void SetupRentalHistoryGrid(Customer customer)
        {
            dataGridViewRentalHistory.DataSource = customer.RentalsHistory
                .Select(r => BuildRentalViewModel(r))
                .ToList(); ;

            dataGridViewRentalHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRentalHistory.ReadOnly = true;
            dataGridViewRentalHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRentalHistory.Columns["Rental"].Visible = false;
        }

        private RentalDataGridViewModel BuildRentalViewModel(Rental r)
        {
            var m = _movieRepository.GetById(r.MovieId);
            if (m == null)
            {
                throw new ArgumentException("The given Movie does not exist.", nameof(r));
            }
            return new RentalDataGridViewModel(m, r);
        }
    }
}
