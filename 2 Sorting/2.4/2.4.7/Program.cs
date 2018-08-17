﻿namespace _2._4._7
{
    /*
     * 2.4.7
     * 
     * 在堆中，最大的元素一定在位置 1 上，
     * 第二大的元素一定在位置 2 或者 3 上。
     * 对于一个大小为 31 的堆，
     * 给出第 k 大的元素可能出现的位置和不可能出现的位置，
     * 其中 k=2、3、4（设元素值不重复）。
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            // k=2 时，
            // 只可能出现在位置 2、3 上（根节点的子结点，深度为 2，根节点深度为 1）
            // k=3 时，
            // 可以直接是根节点的子结点（第 2 或第 3 位，深度为 2），
            // 也可以是第二大元素的子结点（第 4~7 位，也就是深度为 3 的所有位置）
            // k=4 时，
            // 可以直接是根节点的子结点（深度为 2 的点）
            // 也可以是第二大元素的子结点（深度为 3 的点）
            // 也可以是第三大元素的子结点（深度为 4 的点）
            // 故范围为第 2~15 位。
            // 
            // 不难看出第 k 大元素只可能出现在深度＜k 的位置（k>=2）
            // 即位置小于 2^k - 1，(k>=2)
            // 出现范围为 [2, \min \{2^k -1, n\}]，其中 n 为堆的大小。
        }
    }
}
