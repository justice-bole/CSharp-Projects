using System;
 
namespace prime
{
    public class GFG
    {    
                 
        // A function to print all prime
        // factors of a given number n
        public static void primeFactors(int n)
        {
            Console.Write(n + ": ");
            // Print the number of 2s that divide n
            while (n % 2 == 0)
            {
                Console.Write(2 + " x ");
                n /= 2;
            }
 
            // n must be odd at this point. So we can
            // skip one element (Note i = i +2)
            for (int i = 3; i <= Math.Sqrt(n); i+= 2)
            {
                // While i divides n, print i and divide n
                while (n % i == 0)
                {
                    Console.Write(i + " x ");
                    n /= i;
                }
            }
 
            // This condition is to handle the case when
            // n is a prime number greater than 2
            if (n > 2)
                Console.Write(n);
        }
     
        // Driver Code
        public static void Main()
        {
            for(int i = 1; i <= 1000; i++)
            {
                primeFactors(i);
                Console.WriteLine();
            }
            
        }
 
    }
}
