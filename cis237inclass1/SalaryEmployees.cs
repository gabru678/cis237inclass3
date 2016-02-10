using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    // Use the ':' to denote that this class should inherit from the class listed after the ':' 
    class SalaryEmployees : Employee
    {
        // Add backing field for the salary
        private decimal salary;

        // Add property for the salary
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
        }

        /// <summary>
        /// 3 Parameter constructor that takes the following arguments
        /// 
        /// </summary>
        /// <param name="firstname"> First name</param>
        /// <param name="lastName"></param>
        /// <param name="salary"> Yearly salary the employee Earns</param>
        public SalaryEmployees(string firstname, string lastName, decimal salary) : base(firstname, lastName)
        {
            //// this is the not best method to use
            //this.firstName = firstName;

            // Assign the passed in salary to the class level one.  The first and Last names that were passed in are assigned
            // by caling the parents constructor
            // the arent's cnstructor is called by using the : base(firstname, lastname)
            this.salary = salary;



        }

        /// <summary>
        /// Print out the information of the class in a readable format
        /// </summary>
        /// <returns> String consisting of first name, ast name, and salary</returns>
        public override string ToString()
        {
            // Base.ToString() cals the ToString method of the parent class
            // we can get a full string of all the properties by concatinating te parent's ToString
            // with the salary of this class.  We leave the work of creating the parent's information
            // to the parent class
            // then it would return what the parent has + what we end up doing.
            return base.ToString() + " " + this.Salary.ToString("C");
        }
    }
}
