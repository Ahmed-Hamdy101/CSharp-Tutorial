using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.H.iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array :");
            int size =int.Parse(Console.ReadLine());
            int[]space= new int[size];
            for (int i = 0; i < space.Length; i++)
            {
              Console.Write("Enter one record:");
              space[i]= int.Parse(Console.ReadLine()); ;
              Console.WriteLine("one record is effected:"+space[i]);
            }
            foreach (var set in space)
            {
              Console.WriteLine("all Set is return:"+set);

            }
            while (size >= 0 )
            {
            Console.Write("\nWarning !!! Do you want to change the number ?\n->");
            size = int.Parse(Console.ReadLine());
            Console.Write("Size is :"+size);
            Console.Write("\nDo you want to turn off the program?\n:>\n1 - 0 -- off\n2 - 1 -- on\n:>");
            int button = int.Parse(Console.ReadLine());
            if (button.Equals(0))
             {
               break;
              }
            else
             {
               Console.Write("\ncontinur .... to change the number?\nEnter:>");
               size = int.Parse(Console.ReadLine());
               Console.WriteLine("\nSize is :" + size);
             }

            }

            do
            {
                Console.Write("Size is :" + size);

            } while (false);
            Console.ReadKey();

        }
    }
}
