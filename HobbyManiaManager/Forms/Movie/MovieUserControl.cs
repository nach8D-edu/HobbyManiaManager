using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using HobbyManiaManager.Forms;
using HobbyManiaManager.Models;

namespace HobbyManiaManager
{
    public partial class MovieUserControl : UserControl
    {
        private CultureInfo cultureInfo;
        private Movie Movie;
        private RentalService _service;
        private CustomersRepository _customersRepository;

        public MovieUserControl()
        {
            InitializeComponent();
            this.cultureInfo = new CultureInfo("es-ES");
            this._service = new RentalService();
            this._customersRepository = CustomersRepository.Instance;
        }

        public void Load(Movie movie)
        {
            this.Movie = movie;
            this.labelId.Text = $"ID: {Movie.Id.ToString()}";
            this.labelId.AutoSize = true;

            this.labelTitle.Text = $"{Movie.Title}({Movie.ReleaseDate.Year})";
            this.labelTitle.AutoSize = true;

            this.labelOriginalTitle.Text = Movie.OriginalTitle;
            this.labelOriginalTitle.AutoSize = true;

            this.labelGenres.Text = Movie.GenresAsSting;
            this.labelGenres.AutoSize = true;

            this.pictureBoxPoster.Load(Movie.PosterUrl(200));

            this.labelOverview.Text = Movie.Overview;
            this.labelOverview.AutoSize = true;
            this.labelVotesCount.Text = $"{Movie.VoteCount.ToString("N0", cultureInfo)} Votes";

            this.pictureBoxAvailable.BorderStyle = BorderStyle.None;

            this.circularProgressBarVotes.Value = (int)Math.Round(Movie.VoteAverage * 10);
            this.circularProgressBarVotes.Text = $"{Math.Round(Movie.VoteAverage * 10)}%";

            this.labelOriginalTitle.Location = new Point(this.labelOriginalTitle.Location.X, this.labelTitle.Bottom + 10);
            this.labelGenres.Location = new Point(this.labelGenres.Location.X, this.labelOriginalTitle.Bottom + 10);
            this.circularProgressBarVotes.Location = new Point(this.circularProgressBarVotes.Location.X, this.labelGenres.Bottom + 10);
            this.labelOverview.Location = new Point(this.circularProgressBarVotes.Right + 10, this.labelGenres.Bottom + 10);
            this.labelVotesCount.Location = new Point(this.labelVotesCount.Location.X, this.circularProgressBarVotes.Bottom + 5);

            CheckAvailability(movie);
            this.Refresh();
        }

        private void CheckAvailability(Movie movie)
        {
            bool available = _service.IsAvailable(movie);
            if (available)
            {
                this.pictureBoxAvailable.BackColor = Color.Green;
                this.labelAvailable.Text = "Ready to rent";
                this.buttonStartEndRent.Text = "Start Rent";
            }
            else
            {
                var rental = _service.GetMovieRental(movie.Id);
                var customer = _customersRepository.GetById(rental.CustomerId);
                this.buttonStartEndRent.Text = "End Rent";
                this.pictureBoxAvailable.BackColor = Color.Red;
                this.labelAvailable.Text = $"Not available. Rented by: {customer.Name}({customer.Id})";
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            CheckAvailability(Movie);
        }

        private void buttonStartEndRent_Click(object sender, EventArgs e)
        {
            var rentalForm = new RentalForm(Movie, this);
            rentalForm.ShowDialog();
        }

        private void btnImdb_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Movie.ImdbId))
            {

                string imdbUrl = $"https://www.imdb.com/es-es/title/{Movie.ImdbId}";


                var imdbForm = new ImdbForm(imdbUrl, Movie.Title);
                imdbForm.ShowDialog();
            }

        }
    }
}
