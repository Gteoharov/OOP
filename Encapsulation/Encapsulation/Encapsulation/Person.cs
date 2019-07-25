using System;
namespace Encapsulation
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private string email;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public Person(string firstName, string lastName, int age, decimal salary, string email)
            : this(firstName, lastName, age, salary)
        {
            this.Email = email;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.ValidateName(value);
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.ValidateName(value);
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be 0 or negative number.");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.ValidateEmail(value);
                this.email = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be under 460 BGN.");
                }
                this.salary = value;
            }
        }

        public void ChangeEmail(string newEmail)
        {
            this.Email = newEmail;
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                percentage /= 2;
            }

            this.Salary += (this.Salary * percentage) / 100;
        }

        private void ValidateName(string name)
        {
            if (name.Length < 3)
            {
                throw new ArgumentException("Name must be at least 3 characters.");
            }
        }

        private void ValidateEmail(string email)
        {
            if (!email.Contains("@"))
            {
                throw new ArgumentException("Email need to contain @ character.");
            }

            if (!email.Contains("."))
            {
                throw new ArgumentException("Email need to contain '.' character.");
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
