using System;

namespace Assesment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            FizzBuzz(100);
        }


        static void FizzBuzz(int row )
        {
            for ( int i = 1 ; i < row; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz" + " ");
                }
                   
                else if ( i % 5 == 0)
                {
                    Console.Write("Buzz" + " ");

            }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz" + " ");
                }
                else
                 Console.Write(i + " "); 
            }
        }
    }
}
