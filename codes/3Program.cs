using System;

namespace checkEquality
{
    class Program
    {
        //Function to check if two lines are equal or not
        static void equal(double a1, double b1,
                        double c1, double a2,
                        double b2, double c2)
        {
            if ((a1 / a2 == b1 / b2)
                && (a1 / a2 == c1 / c2)
                && (b1 / b2 == c1 / c2))
                Console.WriteLine(" The given straight" + " lines are equal ");
            else
                Console.WriteLine("The given straight" + " lines are not equal ");
        }
        //Driver code
        static void Main(String[] args)
        {
            double a1 = -2, b1 = 4,
            c1 = 3, a2 = -6,
            b2 = 12, c2 = 9;
            equal(a1, b1, c1, a2, b2, c2);
        }
     }
}
