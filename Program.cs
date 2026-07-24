using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double test1, test2, assignment1, project, weightedAverage;

            Console.Write("Enter Test 1 mark: ");
            test1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Test 2 mark: ");
            test2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Assignment 1 mark: ");
            assignment1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Project mark: ");
            project = Convert.ToDouble(Console.ReadLine());

            weightedAverage = (test1 * 30 + test2 * 50 + assignment1 * 10 + project * 10) / 100;

            Console.WriteLine($"Weighted Average: {weightedAverage:F2}");

            if (weightedAverage >= 50)
            {
                Console.WriteLine("Student qualifies to write the exam.");
            }
            else
            {
                Console.WriteLine("Student does not qualify to write the exam.");
            }

            Console.ReadLine();
        }
    }
}