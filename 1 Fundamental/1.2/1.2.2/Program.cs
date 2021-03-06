﻿using System;
using System.Collections.Generic;
using Geometry;

namespace _1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the value of N:");
            var N = int.Parse(Console.ReadLine());
            var intervalList = new List<Interval1D>();

            if (N < 2)
            {
                Console.WriteLine("Make sure there are at least 2 Intervals");
                return;
            }

            // 读取并建立间隔数组
            Console.WriteLine("Type the data, make sure there is a space between two numbers.\nExample: 0.5 1");
            for (var i = 0; i < N; i++)
            {
                var temp = Console.ReadLine();
                var lo = double.Parse(temp.Split(' ')[0]);
                var hi = double.Parse(temp.Split(' ')[1]);

                if (lo > hi)
                {
                    var t = lo;
                    lo = hi;
                    hi = t;
                }

                intervalList.Add(new Interval1D(lo, hi));
            }

            // 判断是否相交并输出
            for (var i = 0; i < N; i++)
            {
                for (var j = i + 1; j < N; j++)
                {
                    if (intervalList[i].Intersect(intervalList[j]))
                    {
                        Console.WriteLine($"{intervalList[i].ToString()} {intervalList[j].ToString()}");
                    }
                }
            }
        }
    }
}