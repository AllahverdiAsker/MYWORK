using System;

namespace Thiswork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int r = 5;
            int o = 6;
            That(11, 34, 22);
        }


        static int That(int n,int r,int o)
        {
            
            if (n >= r && n >= o)
            {
                Console.WriteLine(n);
                int result = n;
                return result;

            }

            else if (r >= n && r >= o)
            {

                Console.WriteLine(r);
                int result = r;
                return result;
            }
            else
            {
                Console.WriteLine(o);
                int result = o;
                return result;
            }
            
            


        }
    }
}
