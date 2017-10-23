﻿namespace _1._3._13
{
    /*
     * 1.3.13
     * 
     * 假设某个用例程序会进行一系列入列和出列的混合队列操作。入列操作会将整数 0 到 9 按顺序插入队列；
     * 出列操作会打印出返回值。下面哪种序列是不可能产生的？
     * a. 0 1 2 3 4 5 6 7 8 9
     * b. 4 6 8 7 5 3 2 9 0 1
     * c. 2 5 6 7 4 8 9 3 1 0
     * d. 4 3 2 1 0 5 6 7 8 9
     * 
     */
    class Program
    {
        // b, c, d 不可能出现
        static void Main(string[] args)
        {
            // a. 全部入列之后再依次出列
            // 根据题意，第一个入列的必定是 0，那么根据队列的特性，0 一定是最先输出的
            // 因此 b, c, d 都是错误的
        }
    }
}
