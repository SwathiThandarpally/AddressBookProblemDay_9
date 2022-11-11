using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        internal void CreateContact()
        {
            throw new NotImplementedException();
        }

        internal void DeleteContacts(string? delete)
        {
            throw new NotImplementedException();
        }

        internal void Edit(string? edit)
        {
            throw new NotImplementedException();
        }
    }

    
}
