using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_code2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wish user
            string name;
            Console.WriteLine("Enter Your Name:");
            name = Console.ReadLine();
            Console.WriteLine("Good Evening" + name);
            Console.ReadKey();
        }
    }
}
