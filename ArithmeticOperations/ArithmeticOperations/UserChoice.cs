using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperations
{
    public class UserChoice
    {
        public double number1;
        public double number2;
        public int choice;

        public UserChoice()
        {          
            int flag = 0;
            do
            {
                Console.Write("Please enter first number: ");
                string str1 = Console.ReadLine();
                if (CheckOnDouble(str1, number1))
                {
                    number1 = double.Parse(str1);
                    flag = 0;
                }
                else
                {
                    flag = 1;
                }
            } while (flag == 1);

            do
            {
                Console.Write("Please enter second number: ");
                string str2 = Console.ReadLine();
                if (CheckOnDouble(str2, number2))
                {
                    number2 = double.Parse(str2);
                    flag = 0;
                }
                else
                {
                    flag = 1;
                }
            } while (flag == 1);

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

        public bool CheckOnInt(string str, int digit)
        {
            //string value = Console.ReadLine();
            //double number;
            if (int.TryParse(str, out digit))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Unable to parse '{0}', try again and enter only number!!!", str);
                return false;
            }
        }

        public void OperationChoice()
        {           
            int flag = 0;           
            do
            {
                Console.WriteLine("Please choose number of arithmetic operation!");
                Console.WriteLine("If you choose multiplу, enter 1 ");
                Console.WriteLine("If you choose division, enter 2 ");
                Console.WriteLine("If you choose sum, enter 3 ");
                Console.WriteLine("If you choose subtraction, enter 4 ");
                string str3 = Console.ReadLine();

                if (CheckOnInt(str3, choice))
                {
                    choice = int.Parse(str3);
                    flag = 0;
                }
                else
                {
                    flag = 1;
                }
            } while (flag == 1);

            ExecutionOfTheSelectedOperation();
        }

        public void ExecutionOfTheSelectedOperation()
        {
            switch (choice)
            {
                case 1: Multiply();break;
                case 2: Division();break;
                case 3: Sum();break;
                case 4: Subtraction();break;
                default: break;
            }
        }

        public void Multiply()
        {
            double resultOfMultiplу = number1 * number2;
            Console.WriteLine($"The result of multiplу is : {resultOfMultiplу:N}");
        }
        public void Division()
        {
            double resultOfDivision = number1 / number2;
            Console.WriteLine($"The result of division is : {resultOfDivision:N}");
        }
        public void Sum()
        {
            double resultOfSum = number1 + number2;
            Console.WriteLine($"The result of sum is: {resultOfSum:N}");
        }
        public void Subtraction()
        {
            double resultOfSubtraction = number1 - number2;
            Console.WriteLine($"The result of subtraction is: {resultOfSubtraction:N}");
        }
    }
}
