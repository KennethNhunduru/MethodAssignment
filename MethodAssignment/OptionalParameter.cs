using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class OptionalParameter
    {
        /*When a parameter is passed to the method, it is called an ARGUMENT.
          When calling methods with multiple parameters, the method call must have the same number of arguments 
          as there are parameters, and the arguments must be in the same order as the parameters.*/

        /*In C# DEFAULT PARAMETER VALUES CAN BE DECLARED WITH THE EQUALS(=) SIGN. 
          When the method is then called without an argument, the default value is used.
          A parameter with a default value is often known as an OPTIONAL PARAMETER.*/

        /*It is possible to send arguments with the "key:value" syntax.
          That way the order of the arguments does not matter.*/

        public int Num1;
        public int Num2 = 4;

        //CREATING A METHOD THAT TAKES TWO INTEGERS AS PARAMETERS.

        public int MutiplyNumbers(int Num1, int Num2) //SETTING THE DEFAULT VALUE FOR Y = 4, MAKES IT AN OPTIONAL PARAMETER.
        {
            int result = Num1 * Num2; //Integer value to be returned by the math operation.
            Console.WriteLine("The product from multiplying: " + Num1 + " by " + Num2 + " is: " + result);
            return result;
        } 
    }
}
