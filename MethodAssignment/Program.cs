using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {        
        static void Main(string[] args)
        {
            //INSTANTIATING THE OPTIONAL PARAMETER CLASS.
            OptionalParameter OP = new OptionalParameter();

            //REQUESTING USER INPUT FOR THE FIRST OF TWO NUMBERS.

            Console.WriteLine("Enter the first of your two numbers for the math operation: ");
            OP.Num1 = Convert.ToInt32(Console.ReadLine());

            //REQUESTING USER INPUT FOR THE OPTIONAL SECOND OF TWO NUMBERS.
            
            Request:
            Console.WriteLine("Do you want to enter the second number for the math operation (Optional)?: \nType in  YES or NO.");

            //capturing the user input in response to request for optional input, and converting it to lowercase.
            string userChoice = (Console.ReadLine()).ToLower();
            Console.ReadLine();
            
            if (userChoice == "yes")
            {
                Console.WriteLine("You have chosen to enter the second number.");
                Console.WriteLine("Enter your second number: ");
                OP.Num2 = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();                
            }
            
            else if (userChoice == "no")
            {
                Console.WriteLine("The default value for the second number will be used for the operation.");
                Console.ReadLine();                              
            }
            
            else 
            {
                Console.WriteLine("Your input data is not in the correct format.");
                Console.ReadLine();
                goto Request;
            }
            
            //Calling the "MultiplyNumbers" method in the OptionalParameters class and passing in the one or two numbers entered.
            OP.MutiplyNumbers(OP.Num1, OP.Num2);
            Console.ReadLine();                       
        }
    }
}








