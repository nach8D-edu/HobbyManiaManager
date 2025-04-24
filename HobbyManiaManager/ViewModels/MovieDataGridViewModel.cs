using System;
using HobbyManiaManager.Models;

namespace HobbyManiaManager.ViewModels
{
    public class MovieDataGridViewModel
    {
        public MovieDataGridViewModel(Movie m)
        {
            Id = m.Id;
            Title = m.Title;
            OriginalTitle = m.OriginalTitle;
            ReleaseDate = m.ReleaseDate;
            VoteAverage = Math.Round(m.VoteAverage *10);
        }

        public int Id { get; set; }

        public string Title { get; set; }
        
        public string OriginalTitle { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double VoteAverage { get; set; }
    }
}