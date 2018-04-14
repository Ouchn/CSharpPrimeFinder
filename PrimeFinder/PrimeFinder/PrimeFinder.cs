using System;
using System.IO;

class Primer
{
    public static void Main()
    {
        //choose mode
        while (true)
        {
            Console.WriteLine("Enter Mode (single, range, end)");
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
        int input = ReadInt();

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
        int start = ReadInt();
        Console.WriteLine("Enter end int");
        int end = ReadInt();

        //loop
        for (int counter = start; counter <= end; counter++)
        {
            if (IsPrime(counter))
            {
                Console.WriteLine(counter);
            }
        }
    }

    static bool IsPrime(int number)
    {
        int test = (int)Math.Floor((decimal)number/2);
        while (test > 1)
        {

            //test vars
            float result = number % test;

            //Return False
            if (result == 0)
            {
                return false;
            }
            test -= 1;
        }
        return true;
    }
    static int ReadInt()
    {
        int x = 0;
        bool y = false;
        while (!y)
        {
            try
            {
                x = int.Parse(Console.ReadLine());
                y = true;
            }
            catch
            {
                Console.WriteLine("Error: Please try again.");
            }
        }
        return x;
    }
}