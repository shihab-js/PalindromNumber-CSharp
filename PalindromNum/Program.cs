using System;

namespace PalindromNum
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int n, r, sum = 0, temp;
            //print message to show users
            Console.Write("Enter the number: ");
            //input number from user
            n = int.Parse(Console.ReadLine());
            //store the number in a temporary variable
            temp = n;

            //continue the program while n greater than 0
            while (n > 0)
            {
                //modulus the number by 10 and store the remainder 
                r = n % 10;
                //Multiply the sum by 10 and add the remainder
                sum = (sum * 10) + r;
                //divide the number by 10 and store it n
                n = n / 10;
            }
            //compare the new number with orginal number
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
