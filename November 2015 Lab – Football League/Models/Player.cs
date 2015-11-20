using System;

namespace November_2015_Lab___Football_League.Models
{
    public class Player
    {
        private const int minimumAllowedYear = 1980;
        private string firstName;
        private string lastName;
        private decimal salary;
        private DateTime dateOfBirth;

        private string CheckCorrectName(String name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }
            return name;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = CheckCorrectName(value); }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = CheckCorrectName(value); }
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salaray cannot be less than zero");
                }
                else
                {
                    this.salary = value;
                }
                
            }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (value.Year.CompareTo(minimumAllowedYear) < 0)
                {
                    throw new ArgumentException("Date of birth cannot be earlier than " + minimumAllowedYear );
                }
                this.dateOfBirth = value;
            }
        }

        public Team Team { get; set; }
        public Player(string firstName, string lastName, decimal salary, DateTime dateOfBirth, Team team)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            DateOfBirth = dateOfBirth;
            Team = team;
        }

        public override string ToString()
        {
            return "Name: " + this.firstName + " " + this.lastName + ", Salary: " + this.salary + ", Date of Birth: " +
                   this.dateOfBirth.ToShortDateString() + ", Team: " + Team.Name;
        }
    }
}