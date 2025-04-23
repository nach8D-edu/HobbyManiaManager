using System;
using HobbyManiaManager.Models;

namespace HobbyManiaManager.ViewModels
{
    public class MovieDataGridViewModel
    {
        public MovieDataGridViewModel(Movie m)
        {
            this.Id = m.Id;
            this.Title = m.Title;
            this.OriginalTitle = m.OriginalTitle;
            this.ReleaseDate = m.ReleaseDate;
            this.VoteAverage = Math.Round(m.VoteAverage *10);
        }

        public int Id { get; set; }

        public string Title { get; set; }
        
        public string OriginalTitle { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double VoteAverage { get; set; }
    }
}