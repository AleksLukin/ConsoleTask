using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bool accessAllowed;

            string storePassword = "qwerty";
            string enteredPassword = Console.ReadLine();

            if (storePassword==enteredPassword)
            {
                accessAllowed = true;
            }
            else
            {
                accessAllowed = false;
            }
            Console.WriteLine(accessAllowed);
            Console.ReadLine();
        }
    }
}
