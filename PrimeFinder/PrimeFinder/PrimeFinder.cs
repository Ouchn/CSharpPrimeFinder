using System;
using System.IO;

class Primer
{
    public static void Main()
    {
        //choose mode
        while (true)
        {
            Console.WriteLine("Enter Mode");
            string runtype = Console.ReadLine();
            if (runtype == "single")
            {
                SingleInput();
            }
            else if (runtype == "range")
            {
                Range();
            }
            else if (runtype == "end")
            {
                break;
            }
        }
    }

    static void SingleInput()
    {
        Console.WriteLine("Input Int");
        int input = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(input))
        {
            Console.Write("IsPrime\n");
        }
        else
        {
            Console.Write("NotPrime\n");
        }
    }

    static void Range()
    {

        //inputs
        Console.WriteLine("Enter start int");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter end int");
        int end = Convert.ToInt32(Console.ReadLine());

        //loop
        for (int counter = start; counter <= end; counter++)
        {
            if (IsPrime(counter))
            {
                Console.WriteLine(counter);
            }
        }
    }

    static bool IsPrime(int testifprime)
    {
        int test;
        test = testifprime - 1;
        while (test != 1)
        {

            //test vars
            float result = testifprime % test;

            //Return False
            if (result == 0)
            {
                return false;
            }
            test = test - 1;
        }
        return true;
    }
}