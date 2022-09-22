using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAndControlFlowApp
{
    public static class LoopTypes
    {
        internal static string HighestDoWhileLoop(List<int> nums)
        {

            int index = 1;
            int highest = nums[0];

            do
            {
                if (nums[index] > highest) highest = nums[index];
                index++;
            } while (index < nums.Count);

            return Convert.ToString(highest);
        }

        internal static string HighestForEachLoop(List<int> nums)
        {
            int highest = nums[0];

            foreach (int num in nums)
            {
                if (num > highest) highest = num;
            }

            return Convert.ToString(highest);
        }

        internal static string HighestForLoop(List<int> nums)
        {
            int highest = nums[0];

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] > highest) highest = nums[i];
            }

            return Convert.ToString(highest);

        }

        internal static string HighestWhileLoop(List<int> nums)
        {
            int index = 1;
            int highest = nums[0];

            while (index < nums.Count())
            {
                if (nums[index] > highest) highest = nums[index];
                index++;
            }

            return Convert.ToString(highest);
        }
    }
}
