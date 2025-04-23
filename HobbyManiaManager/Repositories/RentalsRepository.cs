using System;
using System.Collections.Generic;
using System.Linq;
using HobbyManiaManager.Models;

namespace HobbyManiaManager.Repositories
{
    public class RentalsRepository
    {
        private static RentalsRepository instance;
        List<Rental> Rentals;

        private RentalsRepository()
        {
            Rentals = new List<Rental>();
        }

        public static RentalsRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RentalsRepository();
                }
                return instance;
            }
        }

        public void Add(Rental rental)
        {
            Rentals.Add(rental);
        }

        public List<Rental> GetCustomerRentals(int customerId)
        {
            return Rentals
                .Where(r => r.CustomerId == customerId)
                .Select(r => (Rental)r.Clone())
                .ToList();
        }

        public List<Rental> GetAll()
        {
            return Rentals
                .Select(r => (Rental)r.Clone())
                .ToList();
        }

        public void Remove(Rental rental)
        {
            if (!Rentals.Remove(rental))
            {
                throw new InvalidOperationException("The specified rental does not exist in the list and could not be removed.");
            }
        }
    }
}
