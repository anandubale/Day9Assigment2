using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class ToEditContacts
    {
        private string Firstname ="anand" ;
        private string Lastname = "ubale";
        private string Address = "Pawansut Nagar";
        private string City = "Mehkar";
        private string State = "Maharatra" ;
        private string ZIP = "443301";
        private string Phonenumber = "7888289884";
        private string EmailId = "au26199@gmail.com";

        public string FirstName
        {
            get { return Firstname; }
            set { Firstname = value; }
        }

        public string LastName
        {
            get { return Lastname; }
            set { Lastname = value; }
        }

        public string ADDRESS
        {
            get { return Address; }
            set { Address = value; }
        }

        public string CITY
        {
            get { return City; }
            set { City = value; }
        }

        public string STATE
        {
            get { return State; }
            set { State = value; }
        }

        public string ZIPCode
        {
            get { return ZIP; }
            set { ZIP = value; }
        }

        public string PhoneNumber
        {
            get { return Phonenumber; }
            set { Phonenumber = value; }
        }

        public string EmailID
        {
            get { return EmailId; }
            set { EmailId = value; }
        }

    }
}
