using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range of {int.MinValue:N0} to {int.MaxValue:N0}.");
            //Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range of {double.MinValue:N0} to {double.MaxValue:N0}.");
            //Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range of {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");
            
            double a = 0.1; 
            double b = 0.2; 
            if (a + b == 0.3) 
            { 
                Console.WriteLine($"{a} + {b} equals 0.3");
            } 
            else 
            { 
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }

            decimal c = 0.1M; 
            decimal d = 0.2M; 
            if (c + d == 0.3M) 
            { 
                Console.WriteLine($"{c} + {d} equals 0.3");
            } 
            else 
            { 
                Console.WriteLine($"{c} + {d} does NOT equal 0.3");
            }
        }
    }
}
