using System;

namespace bigger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("");
            string[] str = Console.ReadLine().Split(' ');
            int num1, num2, num3;

            num1 = int.Parse(str[0]);
            num2 = int.Parse(str[1]);
            num3 = int.Parse(str[2]);

            // 使用排序函數將數字排序
            int[] numbers = { num1, num2, num3 };
            Array.Sort(numbers);

            // 顯示排序後的數字
            Console.Write("");
            foreach (int num in numbers)
            {
                Console.Write(num+" ");
            }
        }
    }
}