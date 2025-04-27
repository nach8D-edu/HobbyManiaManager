using System;
using HobbyManiaManager.Models;
using HobbyManiaManager.Repositories;

namespace HobbyManiaManager
{
    public class RentalService
    {
        public readonly MoviesRepository _moviesRepository;
        public readonly RentalsRepository _rentalsRepository;
        public readonly CustomersRepository _customersRepository;

        public RentalService()
        {
            _moviesRepository = MoviesRepository.Instance;
            _rentalsRepository = RentalsRepository.Instance;
            _customersRepository = CustomersRepository.Instance;
        }

        public void Rent(Customer customer, Movie movie, string notes = null, DateTime? startDate = null)
        {
            if (!IsAvailable(movie))
            {
                throw new InvalidOperationException("This movie is already rented.");
            }
            var rental = new Rental(movie.Id, customer.Id, notes, startDate);
            _rentalsRepository.Add(rental);
            Log();
        }


        public void FinishRental(Customer customer, Movie movie, string notes, DateTime endDate)
        {
            var rentals = _rentalsRepository.GetCustomerRentals(customer.Id);

            var rental = rentals.Find(r => r.MovieId == movie.Id);
            if (rental == null)
            {
                throw new Exception($"There is no active rental for movieId={movie.Id} from customerId={customer.Id}");
            }

            rental.EndDate = endDate;
            rental.Notes = notes;

            _customersRepository.AddRentalToHistory(customer.Id, rental);
            _rentalsRepository.Remove(rental);
            Log();
        }

        private void Log()
        {
            foreach (var rental in _rentalsRepository.GetAll())
            {
                Console.Write(rental.ToString());
            }

            Console.WriteLine("");

            foreach (var customers in _customersRepository.GetAll())
            {
                Console.Write(customers.ToString());
            }
        }

        public bool IsAvailable(Movie movie)
        {
            return !_rentalsRepository.GetAll().Exists(r => r.MovieId == movie.Id);
        }

        public Rental GetMovieRental(int id)
        {
            return _rentalsRepository.GetAll().Find(r => r.MovieId == id);
        }
    }
}
