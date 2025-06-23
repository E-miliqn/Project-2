using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class Customers
    {
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private int birthYear;
        public int BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }

        private double budget;
        public double Budget
        {
            get { return budget; }
            set { budget = value; }
        }
        public Customers(int number, string firstName, string lastName, int birthYear, double budget)
        {
            Number = number;
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            Budget = budget;
        }

    }
}

