﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            while( i <= 100)
            {
                if(i % 2 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.Read();
        }
    }
}
