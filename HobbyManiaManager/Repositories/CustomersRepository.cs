using System;
using System.Collections.Generic;
using System.Linq;
using HobbyManiaManager.Models;

namespace HobbyManiaManager
{
    public class CustomersRepository
    {
        private static CustomersRepository instance;
        private List<Customer> customers;

        private CustomersRepository()
        {
            customers = new List<Customer>();
        }

        public static CustomersRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomersRepository();
                }
                return instance;
            }
        }

        public Customer GetById(int id) => (Customer)(customers.Find(m => m.Id == id)?.Clone());

        public void Add(Customer customer)
        {
            if (customers.Exists(c => c.Id == customer.Id))
            {
                throw new ArgumentException($"A customer with ID {customer.Id} already exists.", nameof(customer.Id));
            }
            customers.Add((Customer)customer.Clone());
            Console.Write(customer);
        }

        public void AddRentalToHistory(int customerId, Rental rental)
        {
            if (rental == null)
            {
                throw new ArgumentNullException(nameof(rental), "Rental object cannot be null");
            }

            var customer = customers.Find(c => c.Id == customerId);
            if (customer == null)
            {
                throw new ArgumentException($"No customer found with ID {customerId}", nameof(customerId));
            }

            customer.RentalsHistory.Add(rental);
            Console.Write(customer);
        }

        public List<Customer> GetAll()
        {
            return customers.Select(c => (Customer)c.Clone())
                .ToList();
        }

        public void Update(Customer updatedCustomer)
        {
            var customer = customers.Find(c => c.Id == updatedCustomer.Id);
            if (customer == null) {
                throw new ArgumentException($"No customer found with ID {updatedCustomer.Id}");
            }

            customer.Name = updatedCustomer.Name;
            customer.PhoneNumber = updatedCustomer.PhoneNumber;
            customer.RegistrationDate = updatedCustomer.RegistrationDate;
            customer.Email = updatedCustomer.Email;
            customer.Avatar = updatedCustomer.Avatar;
            // TODO: History??
            Console.Write(customer);
        }
    }
}

