using System;
using System.Collections.Generic;
using System.Linq;
using HobbyManiaManager.Models;

namespace HobbyManiaManager
{
    public class CustomersRepository
    {
        private static CustomersRepository _instance;
        private Dictionary<int, Customer> _customers;

        private CustomersRepository()
        {
            _customers = new Dictionary<int, Customer>();
        }

        public static CustomersRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CustomersRepository();
                }
                return _instance;
            }
        }

        public Customer GetById(int id)
        {
            var customer = Get(id);
            return (Customer) customer.Clone();
        }

        private Customer Get(int id)
        {
            if (!_customers.TryGetValue(id, out var customer))
            {
                throw new ArgumentException($"No customer found with ID {id}");
            }

            return customer;
        }

        public void Add(Customer customer)
        {
            if (_customers.ContainsKey(customer.Id))
            {
                throw new ArgumentException($"A customer with ID {customer.Id} already exists.", nameof(customer.Id));
            }
            _customers.Add(customer.Id, (Customer)customer.Clone());
            Console.Write(customer);
        }

        public void AddRentalToHistory(int customerId, Rental rental)
        {
            if (rental == null)
            {
                throw new ArgumentNullException(nameof(rental), "Rental object cannot be null");
            }
            Customer customer = Get(customerId);
            customer.RentalsHistory.Add(rental);
            Console.Write(customer);
        }

        public List<Customer> GetAll()
        {
            return _customers.Values.Select(c => (Customer)c.Clone())
                .ToList();
        }

        public void Update(Customer updatedCustomer)
        {
            Customer customer = Get(updatedCustomer.Id);
            customer.Name = updatedCustomer.Name;
            customer.PhoneNumber = updatedCustomer.PhoneNumber;
            customer.RegistrationDate = updatedCustomer.RegistrationDate;
            customer.Email = updatedCustomer.Email;
            customer.Avatar = updatedCustomer.Avatar;
            Console.Write(customer);
        }
    }
}