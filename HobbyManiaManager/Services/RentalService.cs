using System;
using HobbyManiaManager.Models;
using HobbyManiaManager.Repositories;

namespace HobbyManiaManager
{
    public class RentalService
    {
        public MoviesRepository moviesRepository;
        public RentalsRepository rentalsRepository;
        public CustomersRepository customersRepository;

        public RentalService()
        {
            moviesRepository = MoviesRepository.Instance;
            rentalsRepository = RentalsRepository.Instance;
            customersRepository = CustomersRepository.Instance;
        }

        public void Rent(Customer customer, Movie movie, string notes = null)
        {
            var rental = new Rental(movie.Id, customer.Id, notes);
            rentalsRepository.Add(rental);
            Log();
        }

        public void FinishRental(Customer customer, Movie movie, string notes)
        {
            var rentals = rentalsRepository.GetCustomerRentals(customer.Id);

            var rental = rentals.Find(r => r.MovieId == movie.Id);
            if (rental == null)
            {
                throw new Exception($"There is no active rental for movieId={movie.Id} from customerId={customer.Id}");
            }

            rental.EndDate = DateTime.Now;
            rental.Notes = notes;

            customersRepository.AddRentalToHistory(customer.Id, rental);
            rentalsRepository.Remove(rental);
            Log();
        }

        private void Log()
        {
            foreach (var rental in rentalsRepository.GetAll())
            {
                Console.Write(rental.ToString());
            }

            Console.WriteLine("");

            foreach (var customers in customersRepository.GetAll())
            {
                Console.Write(customers.ToString());
            }
        }

        public bool IsAvailable(Movie movie)
        {
            return !rentalsRepository.GetAll().Exists(r => r.MovieId == movie.Id);
        }

        internal Rental GetMovieRental(int id)
        {
            return rentalsRepository.GetAll().Find(r => r.MovieId == id);
        }
    }
}
