using System;

namespace Find_Numbers_with_Even_Number_of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 555, 901, 482, 1771 };
            Console.WriteLine("{0}", FindNumbers(nums));
        }

        public static int FindNumbers(int[] nums)
        {
            int count = 0;
            foreach(int num in nums)
            {
                if (num.ToString().Length % 2 == 0) count++;
            }
            return count;
        }
    }
}
