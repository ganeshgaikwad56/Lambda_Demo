using System;

namespace LambdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            UC1Name name = new UC1Name();


            Console.WriteLine("*************name********");

            Console.WriteLine("Enter First Name");
            string FirstName=Console.ReadLine();
            string opt=name.FirstnameCheckusingLambda(FirstName);
            if(opt=="FirstName is valid")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(opt);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(opt);
                Console.ResetColor();
            }


            }
        }
    }
