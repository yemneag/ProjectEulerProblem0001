using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblem0001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Invoke th function
            Console.WriteLine("Project Euler Problem 001 " + SolveProjectEulerProblem001());
        }
        /// <summary>
        /// Find the sum of all the multiples of 3 or 5 or 7 below 1000
        /// </summary>
        /// <param name="sum"> the number that is the sum? </param>
        /// <returns> the solution to the problem </returns>
        static int SolveProjectEulerProblem001()
        {
            // Find the sum of all the multiples of 3 or 5 or below 1000
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
}
