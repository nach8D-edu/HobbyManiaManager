using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HobbyManiaManager.Models
{
    public class Customer : ICloneable
    {
        private static int NextId = 1;
        public int Id { get; set; }
        public string Avatar { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public List<Rental> RentalsHistory { get; set; } = new List<Rental>();

        public Customer() { }

        public Customer(int id, string avatar, string name, string email, string phoneNumber, DateTime registrationDate)
        {
            Id = id;
            Avatar =avatar;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            RegistrationDate = registrationDate;
        }

        public object Clone()
        {
            return new Customer(Id, Avatar, Name, Email, PhoneNumber, RegistrationDate)
            {
                RentalsHistory = RentalsHistory
                    .Select(rental => (Rental)rental.Clone())
                    .ToList()
            };
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Customer ID: {Id}");
            sb.AppendLine($"Avatar: {Avatar}");
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Email: {Email}");
            sb.AppendLine($"PhoneNumber: {PhoneNumber}");
            sb.AppendLine("Rental History:");

            if (RentalsHistory == null || !RentalsHistory.Any())
            {
                sb.AppendLine("  └── No rentals found.");
            }
            else
            {
                for (int i = 0; i < RentalsHistory.Count; i++)
                {
                    var rental = RentalsHistory[i];
                    string prefix = (i == RentalsHistory.Count - 1) ? "  └──" : "  ├──";

                    sb.AppendLine($"{prefix} Movie ID: {rental.MovieId}");
                    sb.AppendLine($"      ├─ Start Date: {rental.StartDate:dd/MM/yyyy HH:mm:ss}");
                    sb.AppendLine($"      ├─ End Date: {rental.EndDate?.ToString("dd/MM/yyyy HH:mm:ss")}");
                    sb.AppendLine($"      └─ Notes: {(string.IsNullOrWhiteSpace(rental.Notes) ? "None" : rental.Notes)}");
                }
            }
            return sb.AppendLine().ToString();
        }

        public static int NextCustomerId => ++NextId;

        public static string UnknownAvatar = "https://ui-avatars.com/api/?name=U&size=200";
    }
}
