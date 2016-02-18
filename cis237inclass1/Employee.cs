using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    // This is an abstract class becuse we added the keyword before the word class
    abstract class Employee :INterfaceEmployee
    {
        //Backing fields
        protected string firstName;
        protected string lastName;
        

        //properties for the backing fields
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
        

        ////One Method that is public. Can be accessed from other classes
        //public string GetFullName()
        //{
        //    return this.firstName + " " + this.lastName;
        //}

        //Override method that will print all of the fields
        //It overrides the default ToString that every object gets for free!
        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " ";
        }

        //  an abstract MUST have no body, include a semicolon.  Means that it must be created in the child
        // and the child must create a function for it
        // we made this method abstract because based on the information that this class has
        // we have no idea how to calculate a salary, let alone format one
        // declaring it abstract leaves the implementation details to the child class to figure out.
        public abstract string GetFormattedSalary();

        // the virtual declaration means that is must have a method body, even if it is empty
        // a cirtal mehid CAN be overridden i the child classes, but is not required to be.
        // We made this methdo virtual
        public virtual string GetLastNameFirstName()
        {
            return this.lastName + ", " + this.firstName;
        }

        //One method that is private. Can only be called from inside this class
        private string foo()
        {
            return "FOO";
        }

        //2 Parameter constructor
        public Employee(string firstName, string lastName)
        {
            //Assign the passed in values to the fields
            this.firstName = firstName;
            this.lastName = lastName;

            //Assign the passed in value by the property
            //this.WeeklySalary = weeklySalary;
        }

        //Default constructor
        public Employee()
        {
            //Lets just leave this blank
        }
    }
}
