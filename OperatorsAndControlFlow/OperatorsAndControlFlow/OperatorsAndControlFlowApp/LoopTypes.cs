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
            throw new NotImplementedException();
        }

        internal static string HighestForEachLoop(List<int> nums)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
