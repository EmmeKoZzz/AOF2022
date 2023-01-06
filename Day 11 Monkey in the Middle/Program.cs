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
        
    }
}