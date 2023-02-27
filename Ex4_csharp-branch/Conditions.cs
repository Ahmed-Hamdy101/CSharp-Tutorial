using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.f.Conditions
{
    class Conditions
    {
        static void Main(string[] args)
        {

            int counter=0;
            Console.WriteLine("Increase : Press 1\nDiscard  : Press 0\n>");
            var push = int.Parse(Console.ReadLine());
            if (push==1)
            {
                counter += counter;
            }
            else
            {
                counter -= counter;

            }

            if (counter < 2)
            {
                Console.WriteLine("The counter is reach to 1% !");
            }else if (counter<3) {
                Console.WriteLine("The counter is reach to 2% !");

            }
            else
            {

                Console.WriteLine("The counter is reach to 0% ! Error Loading! Proccess is Faild error :22");

            }

            
        }
    }
}
