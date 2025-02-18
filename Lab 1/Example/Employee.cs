using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Date: September 9 2024
/// Purpose: stores information obtained from employees.txt after being read in Lab1.cs
/// </summary>

namespace Example
{
    /// <summary>
    /// The class which holds all employee information, getters and setters for those values, as well as gross pay
    /// </summary>
    internal class Employee
    {
        private string name;
        private int number;
        private decimal rate;
        private double hours;
        private decimal gross; // (rate*hours), after 40 hours overtime is at time and a half

        /// <summary>
        /// Constructor for employee class, hold employee name, number, rate, hours and their gross pay
        /// <param name="name"> employee's name </param>
        /// <param name="number"> employee's number </param>
        /// <param name="rate"> employee's rate of pay </param>
        /// <param name="hours"> employee's hours worked </param>
        /// </summary>
        public Employee(string name, int number, decimal rate, double hours)
        {
            this.name = name;
            this.number = number;
            this.rate = rate;
            this.hours = hours;
            if (hours > 40) { this.gross = (decimal) ((double) rate * 1.5) * ((decimal)hours - 40) + (rate * 40); } 
            else { this.gross = rate * (decimal) hours; }
        }

        // Getters
        public decimal GetGross() { return gross; }
        public double GetHours() { return hours; }
        public string GetName() { return name; }
        public int GetNumber() { return number; }
        public decimal GetRate() { return rate; }
        // Setters
        public void SetHours(double hours) { this.hours = hours; }
        public void SetName(string name) { this.name = name; }
        public void SetNumber(int number) { this.number = number; }
        public void SetRate(decimal rate) { this.rate = rate; }
        // To String
        public override string ToString()
        {
            return $"{name,-20} {number} {rate:C} {hours,-5} {gross}"; // used to print table line by line shell sort insertion sort selection sort
        }
    }
}
