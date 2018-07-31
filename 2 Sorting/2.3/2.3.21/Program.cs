﻿namespace _2._3._21
{
    /*
     * 2.3.21
     * 
     * 将重复元素排序的比较次数的下界。
     * 完成命题 M 的证明的第一部分。
     * 参考命题 I 的证明并注意当有 k 个主键值时所有元素存在 
     * N!/f_1!f_2!...f_k! 种不同的排列，
     * 其中第 i 个主键值出现的概率为 f_1（即N_p_i，按照命题 M 的记法），
     * 且 f_1+... +f_k=N。
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            // f_i 为第 i 种主键出现的频率，必为非负整数
            // 当主键值各不相同时，我们有
            // k = N，f_1=f_2=...=f_k=1
            // 此时可能的排列总数为 N!/f_1!...f_k!=N!/1=N!
            // 故最少比较次数即为有 N! 个叶子节点的二叉树的最小高度
            // h>=logN!
            // 那么当主键值有重复时，我们同理可以推得
            // h>=log(N!/(f_1!...f_k!))
            // 当主键值有重复时，k < N，
            // 那么为使 f_1+...+f_k=N
            // 必存在一个 f_m > 1，且其他 f_i >= 1
            // 故此时有 f_1!f_2!...f_k! >= 2 成立
            // 因此 N!/f_1!...f_k! >= N!
            // 那么 h >= log(N!/(f_1!...f_k!)) >= log(N!) ~ NlogN
            // 证毕
        }
    }
}
