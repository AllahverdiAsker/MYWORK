using System;

namespace thiswork1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 96;

            This(n);

            
        }

        static int This(int n) { 

            int result1 = (n % 10);

            int result22 = ((n - result1)/10) % 10;

            int result = result1 + result22;

            Console.WriteLine(result);
            return result;
        }

    }
}
