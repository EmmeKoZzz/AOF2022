using System.Diagnostics;
using System.Numerics;

namespace Day_11_Monkey_in_the_Middle;

class App
{
    static void Main()
    {
        string[] monkeysInfo = new StreamReader("/home/mkz/Coding../AOF2022/Day 11 Monkey in the Middle/input.txt")
            .ReadToEnd().Split("\n\n");

        Monkey[] monkeys = new Monkey[monkeysInfo.Length];

        for (int i = 0; i < monkeysInfo.Length; i++)
            monkeys[i] = new Monkey(monkeysInfo[i]);

        // DoRounds(monkeys, 20, 3);
        BigInteger a = 1312341234;
        for (int i = 0; i < 10; i++)
            a = BigInteger.Multiply(a, a);
        
        Stopwatch time = new();
        time.Start();
        for (int i = 0; i < 10000; i++)
            BigInteger.Multiply(a,
                a);
        time.Stop();

        Console.WriteLine(time.Elapsed.TotalNanoseconds + "\n");
        
        Console.WriteLine( BigInteger.Multiply(a,a));

        Console.WriteLine(StringMath.Multiply("12345123451234123412",
            "12345123451234123412"));

        //DoRounds(monkeys, 20, 1);
    }

    static void Round(Monkey[] monkeys, int[] monkeysInspections, int relief)
    {
        for (int i = 0; i < monkeys.Length; i++)
        {
            monkeysInspections[i] += monkeys[i].Play(monkeys, relief);
        }
    }

    static void DoRounds(Monkey[] monkeys, int numRounds, int relief)
    {
        int[] monkeysInspections = new int[monkeys.Length];
        for (int i = 0; i < numRounds; i++)
            Round(monkeys, monkeysInspections, relief);


        Array.Sort(monkeysInspections);
        Console.WriteLine(monkeysInspections[^2] *
                          monkeysInspections[^1]); // ^ this means index from the end and start with 1
    }
}