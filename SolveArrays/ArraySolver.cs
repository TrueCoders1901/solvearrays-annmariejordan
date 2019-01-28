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
            int total = 0;

            foreach (int number in numbers)
            {
                total += number;
            }

            return total;
        }

        public double AverageEvens(int[] numbers)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
