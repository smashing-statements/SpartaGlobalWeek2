using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAndControlFlowApp
{
    public class StonesMethods
    {

        public static int GetStones(int totalPounds)
        {
            int stones = totalPounds / 14;

            return stones;
        }

        public static int GetPounds(int totalPounds)
        {
            int remainder = totalPounds % 14;

            return remainder;
        }
    }
}
