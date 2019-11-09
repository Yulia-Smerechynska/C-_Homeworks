using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthAccounts
{
    public class Accounts
    {
        Dictionary<string, double> bills = new Dictionary<string, double>();

        public Accounts ()
        {
            int flag = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Please enter month: ");
                string month = Console.ReadLine();
                double profit = 0;
                do
                {
                    Console.Write("Please enter profit: ");
                    string str1 = Console.ReadLine();
                    if (CheckOnDouble(str1, profit))
                    {
                        profit = double.Parse(str1);
                        flag = 0;
                    }
                    else
                    {
                        flag = 1;
                    }
                } while (flag == 1);

                bills.Add(month, profit);
            }
            
            SortedDictionary();
        }

        public bool CheckOnDouble(string str, double digit)
        {
            if (Double.TryParse(str, out digit))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Unable to parse '{0}', try again and enter only number!!!", str);
                return false;
            }
        }

        public void SortedDictionary()
        {
            bills = bills.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var item in bills)
            {
             Console.WriteLine(item.Key + " " + item.Value);
            }           
        }

        public void CalculateAndShowTheAverageProfit()
        {
            double sum = 0;
            int count = 0;

            foreach (var item in bills)
            {
             count++;
             sum += item.Value;
            }
            Console.WriteLine($"The Average Profit is : {(sum / count):N}.");           
        }
    }
}
