using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.g.Cond_Switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            string []spec = new string[5];
            spec[0] = "@";
            spec[1] = ".";
            spec[2] = "#";
            spec[3] = "!";
            spec[4] = "%";

            Console.WriteLine("Enter Your Email :") ;
            var  email = Console.ReadLine();

            switch ( email )
            {
                case "Someone.33@gmail.com":
                    Console.WriteLine("Corrected!!");
                    break;
                default:
                    Console.WriteLine("incorrected!!");
                    break;

            }

        }
    }
}
