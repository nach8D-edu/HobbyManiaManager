using System;
using System.Collections.Generic;
using System.Linq;
using HobbyManiaManager.Models;

namespace HobbyManiaManager
{
    public class MoviesRepository
    {
        private static MoviesRepository instance;
        private Dictionary<int, Movie> movies;

        private MoviesRepository() {
            movies = new Dictionary<int, Movie>();
        }

        public static MoviesRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MoviesRepository();
                }
                return instance;
            }
        }

        public Movie GetById(int id)
        {
            if (movies.TryGetValue(id, out var movie))
            {
                return (Movie)movie.Clone();
            }
            return null;
        }
        public void AddAll(List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                this.movies[movie.Id] = (Movie)movie.Clone();
            }
        }

        public List<Movie> GetAll()
        {
           return movies.Values.Select(m => (Movie)m.Clone()).ToList();
        }

        public int Count => movies.Count;
    }
}
