using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace resturant_employee_management
{

    internal class Employee
    {
        // Fields
        private int id;
        private string firstName;
        private string lastName;
        private string role;
        private double salary;
        private DateTime dateOfHire;

        // Properties
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public double Salary
        {
            get { return salary; }
            private set { salary = value; }
        }

        public DateTime DateOfHire
        {
            get { return dateOfHire; }
            set { dateOfHire = value; }
        }

        // Constructors
        public Employee()
        {
            // Default constructor
        }

        public Employee(int id, string firstName, string lastName, string role, double salary, DateTime dateOfHire)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Role = role;
            this.Salary = salary;
            this.DateOfHire = dateOfHire;
        }

        // Methods
        public void Promote(double percentage)
        {
            Salary += Salary * (percentage / 100);
        }

        public void Demote(double percentage)
        {
            Salary -= Salary * (percentage / 100);
        }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
