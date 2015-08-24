using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
 
             Console.WriteLine("Let's do some basic math.");
            
            int number1, number2, finalNumber;

           Console.WriteLine("Enter an integer: ");
           number1 = int.Parse(Console.ReadLine());

           Console.WriteLine("Enter another integer: ");
           number2 = int.Parse(Console.ReadLine());

          finalNumber = number1 + number2;

          Console.WriteLine("The final number is: " + finalNumber);
        }
    }
}
