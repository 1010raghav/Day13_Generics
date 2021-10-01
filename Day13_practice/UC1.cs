using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_practice
{
    class UC1
    {
        public static int Maxint(int First, int second, int third)
        {
            if (First.CompareTo(second)>0 && First.CompareTo(third) > 0 )
            {
                return First;
            }

            if (second.CompareTo(First) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }

            if (third.CompareTo(second) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }

            throw new Exception("First Number , Second Number , Third Number are Same");
        }

        public static double Maxint(double First,double second, double third)
        {
            if (First.CompareTo(second) > 0 && First.CompareTo(third) > 0)
            {
                return First;
            }

            if (second.CompareTo(First) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }

            if (third.CompareTo(second) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }

            throw new Exception("First Number , Second Number , Third Number are Same");
        }

        public static string Maxint(string First, string second, string third)
        {
            if (First.CompareTo(second)>0 && First.CompareTo(third)>0 ||
                First.CompareTo(second) >= 0 && First.CompareTo(third) > 0 ||
                First.CompareTo(second) > 0 && First.CompareTo(third) >= 0)
            {
                return First;
            }

            if (second.CompareTo(First) > 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(First) >= 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(First) > 0 && second.CompareTo(third) >= 0)
            {
                return second;
            }

            if (third.CompareTo(second) > 0 && third.CompareTo(second) > 0 ||
                third.CompareTo(second) >= 0 && third.CompareTo(second) > 0 ||
                third.CompareTo(second) > 0 && third.CompareTo(second) >= 0)
            {
                return third;
            }
            throw new Exception("First Number , Second Number , Third Number are Same");

        }

    }


}
