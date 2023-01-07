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
        
        
        DoRounds(monkeys, 20, 1);
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