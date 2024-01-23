using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Switch_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number (1-3)");
            int number=int.Parse(Console.ReadLine()); // same as convert.Toint32
            
              switch (number)
            {
                case 1:
                    Console.WriteLine("YOU ENTERED '1'");
                    break;
                    case 2:
                    Console.WriteLine("YOU ENTERD '2'");
                    break;
                    case 3:
                    Console.WriteLine("YOU ENTERD '3'");
                    break;
                    default: Console.WriteLine("INVALID INPUT.PLEASE ENTER A NUMBER BETWEEN 1 AND 3.");
                    break;
            }
            Console.ReadLine();
              
            
        }
    }
}
