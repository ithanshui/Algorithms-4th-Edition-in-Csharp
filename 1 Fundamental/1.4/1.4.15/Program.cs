﻿using System;
using Measurement;

namespace _1._4._15
{
    class Program
    {
        // 由于数组已经排序（从小到大），负数在左侧，正数在右侧。
        // TwoSumFaster
        // 设最左侧下标为 lo，最右侧下标为 hi。
        // 如果 a[lo] + a[hi] > 0, 说明正数太大，hi--。
        // 如果 a[lo] + a[hi] < 0，说明负数太小，lo++。
        // 否则就找到了一对和为零的整数对，lo++, hi--。
        //
        // ThreeSumFaster
        // 对于数组中的每一个数 a，ThreeSum 问题就等于求剩余数组中所有和为 -a 的 TwoSum 问题。
        // 只要在 TwoSumFaster 外层再套一个循环即可。
        static void Main(string[] args)
        {
            var split = new char[1] { '\n' };
            var testCases = TestCase.Properties.Resources._1Kints.Split(split, StringSplitOptions.RemoveEmptyEntries);
            var a = new int[testCases.Length];
            for (var i = 0; i < testCases.Length; i++)
            {
                a[i] = int.Parse(testCases[i]);
            }
            Array.Sort(a);
            Console.WriteLine(TwoSum.Count(a));
            Console.WriteLine(TwoSumFaster(a));
            Console.WriteLine(ThreeSum.Count(a));
            Console.WriteLine(ThreeSumFaster(a));
        }

        /// <summary>
        /// TwoSum 的快速实现。（线性级别）
        /// </summary>
        /// <param name="a">需要查找的数组范围。</param>
        /// <returns>数组中和为零的整数对数量。</returns>
        static int TwoSumFaster(int[] a)
        {
            var lo = 0;
            var hi = a.Length - 1;
            var count = 0;
            while (lo < hi)
            {
                if (a[lo] + a[hi] == 0)
                {
                    count++;
                    lo++;
                    hi--;
                }
                else if (a[lo] + a[hi] < 0)
                {
                    lo++;
                }
                else
                {
                    hi--;
                }
            }
            return count;
        }

        /// <summary>
        /// ThreeSum 的快速实现。（平方级别）
        /// </summary>
        /// <param name="a">需要查找的数组范围。</param>
        /// <returns>数组中和为零的三元组数量。</returns>
        static int ThreeSumFaster(int[] a)
        {
            var count = 0;
            for (var i = 0; i < a.Length; i++)
            {
                var lo = i + 1;
                var hi = a.Length - 1;
                while (lo <= hi)
                {
                    if (a[lo] + a[hi] + a[i] == 0)
                    {
                        count++;
                        lo++;
                        hi--;
                    }
                    else if (a[lo] + a[hi] + a[i] < 0)
                    {
                        lo++;
                    }
                    else
                    {
                        hi--;
                    }
                }
            }
            return count;
        }
    }
}
