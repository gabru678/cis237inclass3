using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class HourlyEmployee : Employee
    {
        // Constants or the hours per week, and the weeks per year
        const decimal HOURS_PER_WEEK = 40;
        const decimal WEEKS_PER_YEAR = 52;

        // Create a backing field for the hourly rate
        private decimal hourlyRate;

        // 3 parameter constructor that uss the parent's costuctor to do some of the work
        public HourlyEmployee(string firstName, string lastName, decimal hourlyRate) :
            base(firstName, lastName)
        {
            this.hourlyRate = hourlyRate;
        }

        // Public Property for the Salary backing field
        public decimal Salary
        {
            get
            {
                return this.hourlyRate * WEEKS_PER_YEAR * HOURS_PER_WEEK;
            }
        }

        //Public ovveride of the ToString Method.  It used the parent's ToString method to get some of it's work done.
        public override string ToString()
        {
            return base.ToString() + " " + this.Salary.ToString("C");
        }

        // This is the override for the abstract method we have declared in the employee class. We are required
        // an implementation since it was declared abstract in employee
        public override string GetFormattedSalary()
        {
            return this.Salary.ToString("C");
        }
    }
}
