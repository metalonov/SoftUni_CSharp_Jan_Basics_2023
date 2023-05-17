using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine()); //чете 2*n-на брой цели числа, подадени от потребителя
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= count; i++)
            {
                leftSum += int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= count; i++)
            {
                rightSum += int.Parse(Console.ReadLine());

            }
            if (leftSum == rightSum) //проверява дали сумата на първите n числа
                                     //(лява сума) е равна на сумата на вторите n числа (дясна сума)
            {
                //При равенство печата " Yes, sum = " + сумата;
                Console.WriteLine($" Yes, sum = {rightSum}");
            }
            else
            {
                //иначе печата " No, diff = " + разликата. Разликата се изчислява като положително число (по абсолютна стойност). 
                Console.WriteLine($" No, diff = {Math.Abs(leftSum - rightSum)}");
            }

        }
    }
}
