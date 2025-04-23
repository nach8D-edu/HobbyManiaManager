using System;

namespace HobbyManiaManager.Models
{
    public class Rental : ICloneable
    {
        public int MovieId { get; set; }
        public int CustomerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Notes { get; set; }

        public Rental(int movieId, int customerId, string notes, DateTime? startDate = null)
        {
            MovieId = movieId;
            CustomerId = customerId;
            Notes = notes;
            StartDate = startDate ?? DateTime.Now;
        }

        public object Clone()
        {
            return new Rental(MovieId, CustomerId, Notes)
            {
                StartDate = this.StartDate,
                EndDate = this.EndDate,
                Notes = this.Notes
            };
        }

        public override string ToString()
        {
            return $"Rental Info:\n" +
                   $"- Movie ID: {MovieId}\n" +
                   $"- Customer ID: {CustomerId}\n" +
                   $"- Start Date: {StartDate:dd/MM/yyyy HH:mm:ss}\n" +
                   $"- End Date:  {EndDate?.ToString("dd/MM/yyyy HH:mm:ss")}\n" +
                   $"- Notes: {(string.IsNullOrWhiteSpace(Notes) ? "None" : Notes)}\n";
        }

        public override bool Equals(object obj)
        {
            if (obj is Rental other)
                return MovieId == other.MovieId &&
                       CustomerId == other.CustomerId;

            return false;
        }
    }
}
