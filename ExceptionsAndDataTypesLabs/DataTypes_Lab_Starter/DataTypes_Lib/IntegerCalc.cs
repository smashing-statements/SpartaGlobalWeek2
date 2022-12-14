using System;

namespace DataTypes_Lib
{
    public static class IntegerCalc
    {
        public static int Add(int num1, int num2)
        {
            // product of num1 and num2 will not test correctly unless checked
            if (int.MaxValue < checked(num1 + num2))
            {
                throw new OverflowException();
            }
            else if (checked(num1 + num2) < int.MinValue)
            {
                throw new OverflowException();
            }
            else
            {
                return num1 + num2;
            }

        }

        public static int Subtract(int num1, int num2)
        {
            //Same for this calculator, product of num1 minus num2 
            //must be checked
            if (checked(num1 - num2) < int.MinValue)
            {
                throw new OverflowException();
            }
            else if (int.MaxValue < checked(num1 - num2))
            {
                throw new OverflowException();
            }
            else
            {
                return num1 - num2;
            }
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Can't divide by zero");
            }
            else
            {
                return num1 / num2;
            }

        }

        public static int Modulus(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Can't modulo by zero");
            }
            else
            {
                return num1 % num2;
            }
        }
    }
}
