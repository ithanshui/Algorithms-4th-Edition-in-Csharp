﻿using System;

namespace _1._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var string1 = "hello";
            var string2 = string1;
            string1 = "world";
            Console.WriteLine(string1);
            Console.WriteLine(string2);
        }
    }
}