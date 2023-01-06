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