using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    interface INterfaceEmployee
    {

        // An Inerface contains only method declarations and properties
        // There is no need to put an access modifier down because it will always be public.
        // We are specifiying only public methods and properties.

        // Any class that implements this interface must implement the folowing methods
        // Eve if they are abstract with no method body
        string GetFormattedSalary();

        string GetLastNameFirstName();

        // Any class that implements the interface must implement the  following properties
        string FirstName
        {
            get;
            set;
        }

        string LastName
        {
            get;
            set;
        }
    }
}
