/* Name: Evgenii Litvinov
Date: 06/19/2021
Assignment: Prime number checker
Due Date: 06/16/2021
About this project: I used C# as my programming language.
The function's job is to tell the user if the number is prime or not. 

All work below was performed by Evgenii Litvinov */

using System;
class primnumber {
  static void Main(string[] args)
{
    Console.Write("Enter the Number to check Prime: ");
    var n = Convert.ToUInt32(Console.ReadLine());
    Console.WriteLine(IsPrime(n) ? "Number is prime" : "Number is not prime");
    Console.ReadLine();
}

  public static bool IsPrime(uint n)
{
    var result = true;

    if (n > 1)
    {
        for (var i = 2u; i < n; i++)
        {
            if (n % i == 0)
            {
                result = false;
                break;
            }
        }
    }
    else
    {
        result = false;
    }

    return result;
}
}