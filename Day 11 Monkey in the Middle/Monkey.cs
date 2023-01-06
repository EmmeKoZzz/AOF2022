namespace Day_11_Monkey_in_the_Middle;

public class Monkey
{
    // ATTRIBUTES
    public List<int> Items { get; private set; }
    private string _worryIncrementOperator;
    private int _worryIncrementValue;
    private int _divisibleByTest;
    private int _testTrue;
    private int _testFalse;
    
    // CONSTRUCTOR
    public Monkey(string monkeyInfo)
    {
        Items = new List<int>();
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
                    SetTesting(args);
                    break;
            }
        }

    }
    
    // CONSTRUCTOR METHODS
    private void SetItems(string info)
    {
        string[] items = info.Split(',');
        
        foreach (string item in items)
            Items.Add(int.Parse(item));
    }
    
    private void SetWorryIncrement(string info)
    {
        string[] realInfo = info.Replace("new = old ","").Split(' ');
        _worryIncrementOperator = realInfo[0];
        _worryIncrementValue = realInfo[1]== "old" ? -1 : int.Parse(realInfo[1]);
    }
    
    private void SetTesting(string[] info)
    {
        switch (info[0])
        {
            case "Test":
                _divisibleByTest = int.Parse(info[1].Replace("divisible by ",""));
                break;
            case "If true":
                _testTrue = int.Parse(info[1].Replace("throw to monkey ", ""));
                break;
            case "If false":
                _testFalse = int.Parse(info[1].Replace("throw to monkey ", ""));
                break;
        }
    }

    // DOINGS
    public void Play(Monkey[] monkeyList)
    {
        foreach (int _ in Items)
        {
            int newItem = WorryOperations();
            int monkey = ThrowTest(newItem);
             monkeyList[monkey].Items.Add(newItem);
        }
    }
    
    private int WorryOperations()
    {
        if (_worryIncrementValue == -1) _worryIncrementValue = Items[0];
        
        int item = Items[0];
        Items.RemoveAt(0);
        
        switch (_worryIncrementOperator)
        {
            case "+":
                item += _worryIncrementValue;
                break;
            case "*":
                item *= _worryIncrementValue;
                break;
            default: throw new Exception("invalid operation");
        }
        return item/3;
    }

    private int ThrowTest(int worryLevel)
    { 
        return worryLevel % _divisibleByTest == 0 ? _testTrue : _testFalse;
    }
}