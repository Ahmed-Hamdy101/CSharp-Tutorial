using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Test
    {
        static void Main(string[] args)
        {

            // str to int 

            var tst = "99";
            var tnt = int.Parse(tst);

            // str to double 
            tst += ".1";
            Console.WriteLine(tst);
            var tdt = double.Parse(tst);

            // str to char to int 

            var tct = '1';
            var tcst = int.Parse(tct+"")+1;
            Console.WriteLine(tcst);

            Console.WriteLine("Type ... One Name");
            var st = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var ddd = double.Parse(Console.ReadLine());
            var ch = char.Parse(Console.ReadLine());
            var strong = "1111";
            char x = strong.First();
           
            /*
             - converte to string 
             - converte to double 
             - converte to boolean 
             - converte to int 
             - converte to int 
             -
             -
             */


        }
    }
}
