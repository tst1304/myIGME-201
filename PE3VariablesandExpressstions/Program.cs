using System;

namespace PE3VariablesandExpressstions
{
    /*
     * Author: Tyler Townley
     * Purpose: Promt the user to enter 4 integers and to print out those intergers.
     * Restrictions: user can only enter integers
    */
    class Program
    {
        /*
         * Purpose: Promt the user to enter 4 integers and to print out those intergers.
         * Restrictions: user can only enter integers
        */
        static void Main(string[] args)
        {
            int count = 4;
            string int1 = "";
            string int2 = "";
            string int3 = "";
            string int4 = "";
            while (count > 0) //use a while loop so that whe users can answer the promt a set amount of times
            {
                while (count == 4)
                {
                    Console.WriteLine("Write an integer");
                    int1 = Console.ReadLine();
                    count -= 1;
                }
                while (count == 3)
                {
                    Console.WriteLine("Write an integer");
                    int2 = Console.ReadLine();
                    count -= 1;
                }
                while (count == 2)
                {
                    Console.WriteLine("Write an integer");
                    int3 = Console.ReadLine();
                    count -= 1;
                }
                while (count == 1)
                {
                    Console.WriteLine("Write an integer");
                    int4 = Console.ReadLine();
                    count -= 1;
                }
                if(count == 0)
                {
                    Convert.ToInt32(int1);
                    Convert.ToInt32(int2);
                    Convert.ToInt32(int3);
                    Convert.ToInt32(int4);
                    Console.WriteLine("The 4 intergers are:");
                    Console.WriteLine(int1);
                    Console.WriteLine(int2);
                    Console.WriteLine(int3);
                    Console.WriteLine(int4);

                }
            }

        }
    }
}
