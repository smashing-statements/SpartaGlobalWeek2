using System;
using System.Collections.Generic;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            string[] strings = new string[contents.Count];

            for (int i = 0; i < contents.Count; i++)
            {
                strings[i] = contents[i];
            }

            return strings;
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            string[,,] array1 = new string[length1, length2, length3];

            if (length1 * length2 * length3 > 6)
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }
            else
            {

                for (int i = 0; i < length1; i++)
                {
                    for (int j = 0; j < length2; j++)
                    {
                        for (int k = 0; k < length3; k++)
                        {
                            //I don't know how this works but stack overflow helped me
                            array1[i, j, k] = contents[(i * length2 * length3) + (j * length3) + k];
                        }
                    }
                }

                return array1;

            }
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {

            #region FIRST_METHOD

            /*

            string[][] jaggedArray = new string[2][];
            jaggedArray[0] = new string[countRow1];
            jaggedArray[1] = new string[countRow2];

            int listIterator = 0;

            if (countRow1 + countRow2 > contents.Count)
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }
            else
            {

                //iterate through each row, in this case 2
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    //iterate through the count of the current row
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        //use an iterator independent of these loops to assign list items
                        jaggedArray[i][j] = contents[listIterator++];
                    }
                }

                return jaggedArray;

            }

            */

            #endregion

            #region SYEDS_METHOD

            if (contents.Count < (countRow1 + countRow2))
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }
            return new string[][] {
                (contents.GetRange(0, countRow1).ToArray()),
                (contents.GetRange(countRow1, countRow2).ToArray())
            };


            #endregion
        }
    }
}
