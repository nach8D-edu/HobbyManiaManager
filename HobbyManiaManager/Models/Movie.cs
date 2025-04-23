using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace HobbyManiaManager.Models
{
    public class Movie : ICloneable
    {
        
        private const string BaseImageUrl = "https://image.tmdb.org/t/p/w342";

        public int Id { get; set; }

        public string Title { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }
        
        public string Overview { get; set; }
        
        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        public string PosterUrl(int with = 342) => string.IsNullOrEmpty(this.PosterPath) ? null : $"https://image.tmdb.org/t/p/w{with}{PosterPath}";

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        public string BackdropUrl => string.IsNullOrEmpty(this.BackdropPath) ? null : $"{BaseImageUrl}{BackdropPath}";

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("genre_ids")]
        public List<int> GenreIds { get; set; }

        [JsonIgnore]
        public List<Genre> Genres => GenreIds
            .Where(id => Enum.IsDefined(typeof(Genre), id))
            .Select(id => (Genre)id)
            .ToList();

        public object Clone()
        {
            return new Movie
            {
                Id = this.Id,
                Title = this.Title,
                OriginalTitle = this.OriginalTitle,
                ReleaseDate = this.ReleaseDate,
                Overview = this.Overview,
                PosterPath = this.PosterPath,
                BackdropPath = this.BackdropPath,
                VoteAverage = this.VoteAverage,
                VoteCount = this.VoteCount,
                GenreIds = new List<int>(this.GenreIds)
            };
        }

        public enum Genre
        {
            Action = 28,
            Adventure = 12,
            Animation = 16,
            Comedy = 35,
            Crime = 80,
            Documentary = 99,
            Drama = 18,
            Family = 10751,
            Fantasy = 14,
            History = 36,
            Horror = 27,
            Music = 10402,
            Mystery = 9648,
            Romance = 10749,
            ScienceFiction = 878,
            TVMovie = 10770,
            Thriller = 53,
            War = 10752,
            Western = 37
        }
    }
}
