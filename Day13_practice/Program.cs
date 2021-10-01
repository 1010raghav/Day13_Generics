using System;

namespace Day13_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Max Value");

            int output = UC1.Maxint(11,22,33);
            Console.WriteLine(output);

           double doubleoutput = UC1.Maxint(11.2, 22.1, 33.23);
            Console.WriteLine(doubleoutput);

            string stringoutput = UC1.Maxint("22", "33", "44");
            Console.WriteLine(stringoutput);


        }
    }
}
