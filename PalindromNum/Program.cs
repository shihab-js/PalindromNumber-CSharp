using System;

namespace PalindromNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the number: ");
            n = int.Parse(Console.ReadLine());
            temp = n;

            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if(temp == sum)
            {
                Console.Write("Number is palindorm.");
            }
            else
            {
                Console.Write("Number is not palindrom.");
            }
        }
    }
}
