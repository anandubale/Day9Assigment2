using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Adress Book PRogram in master Branch");

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
                
            }
        }
    }
}
