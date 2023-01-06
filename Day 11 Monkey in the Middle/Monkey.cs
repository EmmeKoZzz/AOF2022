namespace Day_11_Monkey_in_the_Middle;

public class Monkey
{
    // ATTRIBUTES
    public List<int> Items { get; private set; }
    private Dictionary<string, int> _worryIncrement;
    private int _divisibleByTest;
    private int _testTrue;
    private int _testFalse;
    
    // CONSTRUCTOR
    public Monkey(string monkeyInfo)
    {
        string[] monkeyArgs = monkeyInfo.Split('\n');
        
        for(int i = 1 ; i < monkeyArgs.Length ; i++)
        {
            string[] args = monkeyArgs[i].Split(':', StringSplitOptions.TrimEntries);
            switch (args[0])
            {
                case "Starting items":
                    SetItems(args[1]);
                    break;
                case "Operation":
                    SetWorryIncrement(args[1]);
                    break;
                default:
                    SetTesting(args[1]);
                    break;
            }
        }

    }

    private void SetItems(string info)
    {
    }
    
    private void SetWorryIncrement(string info)
    {
    }
    
    private void SetTesting(string info)
    {
    }

    // DOINGS
    public void WorryIncreaser()
    {
    }

    public void Relax()
    {
    }

    public int ThrowTest()
    {
        return 0;
    }
}