using System;

namespace DataTypes_Lib
{
    public class TypeConversion
    {
        public static short UIntToShort(uint num)
        {
            if (num >= short.MaxValue+1)
            {
                throw new OverflowException("Cannot cast to short: uint too large");
            } 
            else
            {
                return (short)num;
            }

        }

        public static long FloatToLong(float num)
        {
            long longedFloat = Convert.ToInt64(num);

            return longedFloat;
        }
    }
}
