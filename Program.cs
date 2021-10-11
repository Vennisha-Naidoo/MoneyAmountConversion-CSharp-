using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking the user for input
            Console.WriteLine("Enter an amount: ");

            //start of try... catch
            try
            {
                //assigning input into variable
                int Amount = Convert.ToInt32(Console.ReadLine());

                //Leaving a line
                Console.WriteLine("");

                //Displaying options
                Console.WriteLine("Choose from the following: ");
                Console.WriteLine("1. Half-dollars");
                Console.WriteLine("2. Quaters");
                Console.WriteLine("3. Dimes");
                Console.WriteLine("4. Nickels");

                Console.WriteLine("");

                //Asking for user choice
                Console.Write("Your choice: ");
                //Assigning the choice input to the variable
                int Choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                //switch statement
                switch (Choice)
                {

                    case 1:
                        //Displaying the called function with an output
                        Console.WriteLine("converted to " + HalfDollars(Amount) + " half-dollars");
                        break;

                    case 2:
                        Console.WriteLine("converted to " + Quarters(Amount) + " quaters");
                        break;

                    case 3:
                        Console.WriteLine("converted to " + Dimes(Amount) + " dimes");
                        break;

                    case 4:
                        Console.WriteLine("converted to " + Nickels(Amount) + " nickels");
                        break;

                    default:
                        //Displaying if invalid input
                        Console.WriteLine("Invalid Entry");
                        break;

                }// end switch statement

            }
            //catching the exception in variable e
            catch (Exception e)
            {
                //Displaying the error message
                Console.WriteLine(e.Message);

            }

            Console.Read();

        }// end main function

        //declaration of HalfDollars function, with a parameter
        static double HalfDollars(int Amt)
        {
            //returning the parameter recieved by 0.50
            return Amt / 0.50;
        }

        //declaration of Quaters function, with a parameter
        static double Quarters(int Amt)
        {
            //returning the parameter received by 0.25
            return Amt / 0.25;
        }

        //declaration of Dimes function, with a parameter
        static double Dimes(int Amt)
        {
            //returning the parameter received by 0.10
            return Amt / 0.10;
        }

        //declaration of Nickels function, with a parameter
        static double Nickels(int Amt)
        {
            //returning the parameter received by 0.05
            return Amt / 0.05;
        }

    }// end class
}
