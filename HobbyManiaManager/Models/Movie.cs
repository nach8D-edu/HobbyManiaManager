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

        public string Status { get; set; }

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

        [JsonProperty("genres")]
        public List<Genre> Genres { get; set; }

        [JsonProperty("imdb_id")]
        public string ImdbId { get; set; }

        public string GenresAsSting => string.Join(", ", Genres.Select(g => g.Name));

        public object Clone()
        {
            return new Movie
            {
                Id = this.Id,
                Title = this.Title,
                OriginalTitle = this.OriginalTitle,
                ReleaseDate = this.ReleaseDate,
                Status = this.Status,
                Overview = this.Overview,
                PosterPath = this.PosterPath,
                BackdropPath = this.BackdropPath,
                VoteAverage = this.VoteAverage,
                VoteCount = this.VoteCount,
                ImdbId = this.ImdbId,
                Genres = this.Genres?.Select(g => new Genre { Id = g.Id, Name = g.Name }).ToList()
             };
        }

        public class Genre
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }
}
