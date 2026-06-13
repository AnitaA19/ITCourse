using System;
using System.Collections.Generic;
using System.Text;

namespace ITCourse.davaleba11
{
    public class ArrayClass : IOutput2, ICalc2
    {
        private int[] data;

        public ArrayClass(int[] data)
        {
            this.data = data;
        }

        public void ShowEven()
        {
            Console.WriteLine("Even values:");

            foreach (int item in data)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }

            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.WriteLine("Odd values:");

            foreach (int item in data)
            {
                if (item % 2 != 0)
                {
                    Console.Write(item + " ");
                }
            }

            Console.WriteLine();
        }

        public int CountDistinct()
        {
            int count = 0;

            for (int i = 0; i < data.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < i; j++)
                {
                    if (data[i] == data[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    count++;
                }
            }

            return count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;

            foreach (int item in data)
            {
                if (item == valueToCompare)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
