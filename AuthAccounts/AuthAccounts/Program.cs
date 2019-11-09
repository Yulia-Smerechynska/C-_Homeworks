using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            
            UserAuthorization user = new UserAuthorization();
            Accounts account = new Accounts();

            if (user.CheckAuthorization())
            {
                account.CalculateAndShowTheAverageProfit();
            }
            else
            {
                Console.WriteLine("Try again later and don`t forget your name and password.");
            }           

            Console.ReadKey();
        }
    }
}
