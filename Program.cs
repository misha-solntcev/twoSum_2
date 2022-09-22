using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Задача.
 Найти два числа из массива, в сумме равных числу к.
    Решение с помощью HashSet.  */

namespace twoSum_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -3, 0, 2, 4, 5 };
            int k = 6;
            List<int> set = new List<int>();
            int[] res = new int[] {0, 0};

            for (int i = 0; i < nums.Length; i++)
            {
                int numberToFind = k - nums[i];
                if (set.Contains(numberToFind))
                {
                    res = new int[] { numberToFind, nums[i] };                    
                }
                set.Add(nums[i]);
            }

            Console.WriteLine($"[{res[0]}, {res[1]}]");
            Console.ReadKey();


        }
    }
}