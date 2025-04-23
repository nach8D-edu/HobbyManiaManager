using System;
using HobbyManiaManager.Models;

namespace HobbyManiaManager.ViewModels
{
    public class RentalDataGridViewModel
    {

        public RentalDataGridViewModel(Movie m, Rental r)
        {
            if (m.Id != r.MovieId) {
                throw new ArgumentException("Rental object is not associated with the given Movie.", nameof(r));
            }
            this.Rental = r;
            this.Movie = $"{m.Id} - {m.Title}";
            this.StartDate = r.StartDate;
            this.EndDate = r?.EndDate;
            this.Notes = r.Notes;
        }

        public Rental Rental { get; set; }

        public string Movie { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Notes { get; set; }
    }
}
