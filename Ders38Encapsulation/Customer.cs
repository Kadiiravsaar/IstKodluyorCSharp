using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders38Encapsulation
{
    public class Customer
    {
        private string _firstName { get; set; }
        public int Id { get; set; }
        public string FirstName {
            get 
            {
                return "Mrs." + _firstName;
            }
            set 
            {
                _firstName = value;
            }
        }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
