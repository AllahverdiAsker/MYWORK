using System;

namespace Mywork3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,5,6,7,88,};
            int n = 7;
            okgo(numbers,n);
            
        }

        static int okgo(int[] numbers,int n) {

            int index = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                 
                if (numbers[i] == n)
                {
                    index = i;
                    break;
                    

                }
            }

            Console.WriteLine(index);
                return index;
                
                


            


                
                

                
                
        }
            

       }
        

        
    }

