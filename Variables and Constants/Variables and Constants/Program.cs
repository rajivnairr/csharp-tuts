﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_and_Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            String firstName = "Rajiv";
            bool isWorking = true;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            const float pi = 3.14f;
            var radius = 5;
            Console.WriteLine(pi * radius * radius);
        }
    }
}
