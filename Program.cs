using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Adress Book PRogram in master Branch");
            /*
            ToGetFullName myname = new ToGetFullName();
            
            FullAdress myadd = new FullAdress();
            MobileNumber mymob = new MobileNumber();
            EMailId myemail = new EMailId();

            

            for (int user = 1; user <= 10; user++)
            { 
                Console.WriteLine("User " + user + ":");

                //------------------------------------------
                Console.WriteLine("Enter your First Name");
                String FirstName = Console.ReadLine();
                Console.WriteLine("Enter your Last Name");
                String LastName = Console.ReadLine();

                //------------------------------------------- 
                
                Console.WriteLine("Enter your Address");
                String Address = Console.ReadLine();
                Console.WriteLine("Enter your city Name");
                String City = Console.ReadLine();
                Console.WriteLine("Enter your state");
                String state = Console.ReadLine();
                Console.WriteLine("Enter your zip code");
                String zip = Console.ReadLine();

                //---------------------------------------------
                Console.WriteLine("Enter your Mobile NUmber");
                String MobileNo = Console.ReadLine();
                Console.WriteLine("Enter your Email id");
                String EmailId = Console.ReadLine();

                

                Console.WriteLine("Full Name: " + ToGetFullName.FirstName(FirstName) + " " + ToGetFullName.LastName(LastName));
                
                Console.WriteLine("Address: " + FullAdress.ADDRESS(Address) + " " + FullAdress.CITY(City) + " " + FullAdress.STATE(state) + " " + FullAdress.ZIP(zip));
                Console.WriteLine("Mobile NUmber: " + MobileNumber.MOBILENUBER(MobileNo));
                Console.WriteLine("Email ID: " + EMailId.EMAILID(EmailId));
                Console.WriteLine("");
            */



            // }
            
            //Uc3 ----To edit existed code

            ToEditContacts t1 = new ToEditContacts();
            /*
            Console.WriteLine("Enter Name You want to edit First Name type");
            t1.FirstName = Console.ReadLine();
            Console.WriteLine("First Name : " + t1.FirstName);

            Console.WriteLine("Enter Name You want to edit First Name type");
            t1.LastName = Console.ReadLine();
            Console.WriteLine("First Name : " + t1.LastName);

            Console.WriteLine("Enter Name You want to edit First Name type");
            t1.ADDRESS = Console.ReadLine();
            Console.WriteLine("First Name : " + t1.ADDRESS);

            Console.WriteLine("Enter Name You want to edit First Name type");
            t1.CITY = Console.ReadLine();
            Console.WriteLine("First Name : " + t1.CITY);

            Console.WriteLine("Enter Name You want to edit First Name type");
            t1.STATE = Console.ReadLine();
            Console.WriteLine("First Name : " + t1.STATE);

            Console.WriteLine("Enter Name You want to edit First Name type");
            t1.ZIPCode = Console.ReadLine();
            Console.WriteLine("First Name : " + t1.ZIPCode);

            Console.WriteLine("Enter Name You want to edit First Name type");
            t1.PhoneNumber = Console.ReadLine();
            Console.WriteLine("First Name : " + t1.PhoneNumber);

            Console.WriteLine("Enter Name You want to edit First Name type");
            t1.EmailID = Console.ReadLine();
            Console.WriteLine("First Name : " + t1.EmailID);
            */

            //uc4 --- To delete existing 

            t1.FirstName = null;
            Console.WriteLine("First Name : " + t1.FirstName);

        }
    }
}
