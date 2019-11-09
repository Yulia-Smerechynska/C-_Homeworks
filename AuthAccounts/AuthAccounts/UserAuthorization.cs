using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthAccounts
{
    public class UserAuthorization
    {       
        public string name;
        public string password;

        public UserAuthorization()
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            Console.Write("Please enter your password: ");
            password = Console.ReadLine();           
            
        }
        public bool CheckAuthorization()
        {
            Console.Write("Please enter your name again to confirm authorization: ");
            string name1 = Console.ReadLine();

            Console.Write("Please enter your password again to confirm authorization: ");
            string password1 = Console.ReadLine();

            if (name1 == name && password1 == password)
            {
                Console.WriteLine($"Authorization confirmed! Hello, {name1}!!!");                
                return true;
            }
            else
            {
                Console.WriteLine("Login and password are invalid, access is denied!!!");
                return false;
            }
        }
    }
}
