using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Townley_HelloWorld
{
    /*
     * Class: Program
     * Author: Tyler
     * Purpose: To print out variables to the console. 
     * Restrictions: Can only add ad subtract variables.
    */
    class Program
    {
        /*
         * Method: Main
         * Purpose: To declare variables and add and subtract those varables.
         * Restrictions: Can only add ad subtract variables.
        */
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 6;
            int num3 = num1 + num2;
            int num4 = num2 - num1;
            Console.WriteLine(num1 + " + " + num2 + " = " + num3);
            Console.WriteLine(num2 + " - " + num1 + " = " + num4);
            if (num3 < 14)
            {
                num3 += 1;
                Console.WriteLine(num3);
            }
            while(num3 < 14)
            {
                num3 += 1;
                Console.WriteLine(num3);
            }
        }
    }
}
