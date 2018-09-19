using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your weight: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Please enter your height: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write($"Your BMI is: {BMI(weight, height)}");
            Console.ReadLine();
        }

        static public double BMI(double weight, double height)
        {
            double BMI = (weight / (height * height));
            Console.WriteLine(BMI);
            return BMI;

        }
    }
}
