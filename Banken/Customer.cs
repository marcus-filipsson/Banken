using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Customer
    {

        public String Name; //här så sparas kundens namn.
        public int Balance; // här sparas hur mycket pengar kunden har.

       

        public String ShowCustomer ()
        {
            return Name + Balance; // här retuneras namnet på kunden och hur mycket pengar den har i ShowCustomer.
        }

    }
}
