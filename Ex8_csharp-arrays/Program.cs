﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.I.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var storageA = new int[6]{1,3,4,5,6,2};
            Console.Write("How much you need for charaters ?\nanswer:");
            var accept = int.Parse(Console.ReadLine());
            var storageC = new string[accept];
            var count = 0;
            while (storageC.Length > count)
            {
                Console.Write("Enter counter key "+count+":\nanswer:");
                storageC[count] =Console.ReadLine();
                Console.WriteLine("You have typped "+storageC[count]);
                count++;
            }    
            void keyword() {
                foreach (var item in storageC)
                {
                Console.Write(item);

                }
            }
            keyword();
            Console.ReadKey();
            var storageB = new int[6]{1,3,4,5,6,2};

        }

    }
}
