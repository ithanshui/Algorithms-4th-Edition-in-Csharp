﻿using System;
using Generics;

namespace _1._3._2
{
    class Program
    {
        // was best times of the was the it (1 left on stack) 
        static void Main(string[] args)
        {
            // 以下是书中给出的 Stack 类中的 Main() 方法
            var stack = new Stack<string>();
            var input = "it was - the best - of times - - - it was - the - -";
            var s = input.Split(' ');

            foreach (var n in s)
            {
                if (!n.Equals("-"))
                    stack.Push(n);
                else if (!stack.IsEmpty())
                    Console.Write(stack.Pop() + " ");
            }

            Console.WriteLine($"({stack.Size()} left on stack)");
        }
    }
}