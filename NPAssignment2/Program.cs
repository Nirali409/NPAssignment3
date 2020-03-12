using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {

            int Userinput;

            while (true)
            {
                Console.WriteLine("Enter one of the options from the menu");
                Console.WriteLine("1.Enter triangle dimensions");
                Console.WriteLine("Press enter to show menu again");
                Console.WriteLine("2.Exit");

                String input = Console.ReadLine();

                int x;
                bool inputIsInteger = int.TryParse(input, out x);

                if (inputIsInteger == false)
                {
                    Console.WriteLine("Please enter a number");
                    Console.ReadLine();
                }
                else
                {
                    Userinput = Convert.ToInt32(input);

                    if (Userinput == 1)
                    {
                        // User is to enter first integer
                        Console.WriteLine("Enter your first integer");
                        int firstInput = int.Parse(Console.ReadLine());

                        // validation for the first number to be integer
                        string userinput = Console.ReadLine(); int a;
                        bool input1IsInteger = int.TryParse(userinput, out a);
                        if (input1IsInteger == false)
                        {
                            Console.WriteLine("enter an integer not a string!");
                            Console.ReadLine();
                        }

                        //user is to enter second integer
                        Console.WriteLine("Enter your second integer");
                        int SecondInput = int.Parse(Console.ReadLine());

                        // validation for the second number to be integer
                        string userinput2 = Console.ReadLine(); int b;
                        bool input2IsInteger = int.TryParse(userinput, out b);
                        if (input2IsInteger == false)
                        {
                            Console.WriteLine("You must enetr an integer not a string!");
                            Console.ReadLine();
                        }

                        //user is to enter third integer
                        Console.WriteLine("Enter your third integer");
                        int thirdInput = int.Parse(Console.ReadLine());

                        // validation for the third number to be integer
                        string userinput3 = Console.ReadLine(); int c;
                        bool input3IsInteger = int.TryParse(userinput, out c);

                        if (input3IsInteger == false)
                        {
                            Console.WriteLine("You must enter an integer not a string!");
                            Console.ReadLine();
                        }

                        //calling Analyze Method
                        Console.WriteLine(EquilateralTriangle.Analyze(firstInput, SecondInput, thirdInput));
                        Console.ReadLine();

                    }
                    else if (Userinput == 2)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("You must enter either 1 or 2");
                        Console.ReadLine();
                    }
                }

            }

        }


    }
}
