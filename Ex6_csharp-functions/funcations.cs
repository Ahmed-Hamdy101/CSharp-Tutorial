using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.g.Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            if (CLI() == "1")
            {
                Console.Write("Ask Me:");
                string answer = Console.ReadLine();
                
            } else if(CLI() == "2") {
                var get = "https://stackOverFollow.com?ask=1%20&&%20SELECT%20*%20FROM%20?";
                Console.Write(get);
                Console.ReadLine();
                Console.ReadKey();
            }
            Console.Write(CLI());

        }
        //void is no return | static return void
        static void sharp(int[] a)
        {
            int[] array = a;
            foreach (var item in array)
            {
                Console.WriteLine(array[item]);
            }
        }

        // function datatype is waiting to return something from method as reference
        static string CLI()
        {
            Console.Write(" ----------------Welcome in Tron------\n1 - Ask Question >\n2-StackOverFollow\n3-Github>\n4-Mafia Call\n5-Decode Message\nEnter:");
            string answer = Console.ReadLine();
            return answer;
        }
    }
}
 

