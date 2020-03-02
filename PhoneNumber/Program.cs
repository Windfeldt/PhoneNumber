using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PN
{
    class Program
    {
        static void Main(string[] args)
        {
            //int input = Convert.ToInt32(Console.ReadLine());
            NumberHandler numberHandler = new NumberHandler();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            Console.WriteLine(numberHandler.GetNumber(firstName, lastName));
            Console.ReadLine();
        }
    }
}
