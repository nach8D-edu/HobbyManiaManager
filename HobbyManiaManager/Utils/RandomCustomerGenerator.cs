using System;


namespace HobbyManiaManager.Utils
{
    public class RandomCustomerGenerator
    {

        private readonly Random _random;

        private static readonly string[] FirstNames = new[]
        {
            "James", "Mary", "John", "Patricia", "Robert", "Jennifer", "Michael", "Linda", "William", "Elizabeth",
            "David", "Barbara", "Richard", "Susan", "Joseph", "Jessica", "Thomas", "Sarah", "Charles", "Karen",
            "Christopher", "Nancy", "Daniel", "Lisa", "Matthew", "Betty", "Anthony", "Margaret", "Mark", "Sandra",
            "Donald", "Ashley", "Steven", "Kimberly", "Paul", "Emily", "Andrew", "Donna", "Joshua", "Michelle",
            "Kenneth", "Carol", "Kevin", "Amanda", "Brian", "Dorothy", "George", "Melissa", "Edward", "Deborah"
        };

        private static readonly string[] LastNames = new[]
        {
            "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez",
            "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson", "Thomas", "Taylor", "Moore", "Jackson", "Martin",
            "Lee", "Perez", "Thompson", "White", "Harris", "Sanchez", "Clark", "Ramirez", "Lewis", "Robinson",
            "Walker", "Young", "Allen", "King", "Wright", "Scott", "Torres", "Nguyen", "Hill", "Flores",
            "Green", "Adams", "Nelson", "Baker", "Hall", "Rivera", "Campbell", "Mitchell", "Carter", "Roberts"
        };

        public RandomCustomerGenerator()
        {
            _random = new Random();
        }

        public string FullName { get;  set; }
        public string Email { get;  set; }
        public string PhoneNumber { get;  set; }
        public string AvatarUrl { get;  set; }
        public DateTime RegistrationDate { get;  set; } 

        public void Generate()
        {
            var firstName = FirstNames[_random.Next(FirstNames.Length)];
            var lastName = LastNames[_random.Next(LastNames.Length)];

            FullName = $"{firstName} {lastName}";
            Email = $"{firstName.ToLower()}.{lastName.ToLower()}@xtec.cat";
            PhoneNumber = GeneratePhoneNumber();
            AvatarUrl = $"https://i.pravatar.cc/200?img={_random.Next()% 70 + 1}";
            RegistrationDate = GenerateRandomDate();
        }

        private string GeneratePhoneNumber()
        {
            return $"+34 {_random.Next(600, 699)} {_random.Next(100000, 999999)}";
        }
        private DateTime GenerateRandomDate()
        {
            var endDate = DateTime.Now; 
            var startDate = endDate.AddYears(-25);

            int range = (endDate - startDate).Days;
            return startDate.AddDays(_random.Next(range)); 
        }

    }
}
