using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_CircleTime
{
    class Validator
    {

        public static bool RunAgain(string message, int num)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                Console.WriteLine($"You have created {num} circle objects. Goodbye.");
                return false;
            }
            else
            {
                Console.WriteLine("That isn't an option!");
                return RunAgain(message, num);
            }

        }
    }
}
