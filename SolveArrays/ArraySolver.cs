using System;
using System.Collections.Generic;


namespace SolveArrays
{
    public class ArraySolver
    {
        public int Sum(int[] numbers)
        {
            int total = 0;

            foreach (int number in numbers)
            {
                total += number;
            }

            return total;
        }

        public int SumEvens(int[] numbers)
        {
            int result = 0;

            foreach (int number in numbers)
                if (number % 2 == 0)
                {
                    result += number;
                }

            return result;

        }

        public double AverageEvens(int[] numbers)
        {

            double sum = 0;
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                //number at index i is even
                if (numbers[i] % 2 == 0)
                {
                    sum = sum + numbers[i];
                    count++;
                }
            }
            if (count == 0)
            {
                return 0;
            }
            return sum / count;
        } 

        

        public bool IsSumOdd(List<int> numbers)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
