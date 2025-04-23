using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HobbyManiaManager.ViewModels;

namespace HobbyManiaManager
{
    public partial class CatalogForm : Form
    {
        private MoviesRepository moviesRepository;
        public CatalogForm()
        {
            InitializeComponent();
            moviesRepository = MoviesRepository.Instance;
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            this.movieUserControl.Load(moviesRepository.GetById(238));

            this.dataGridViewMoviesList.DataSource = moviesRepository.GetAll()
                .Select(m=> new MovieDataGridViewModel(m))
                .ToList();
            this.dataGridViewMoviesList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMoviesList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMoviesList.ReadOnly = true;
            this.dataGridViewMoviesList.Columns["Id"].Visible = false;
            this.dataGridViewMoviesList.Columns["VoteAverage"].HeaderText = "Votes Average";
            this.movieUserControl.Parent = this;
        }

        private void dataGridViewMoviesList_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMoviesList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewMoviesList.SelectedRows[0];
                var id = (int) selectedRow.Cells[0].Value;

                var selected = moviesRepository.GetById(id);
                this.movieUserControl.Load(selected);
            }
        }
    }
}
