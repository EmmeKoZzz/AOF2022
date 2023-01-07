using System.Text.RegularExpressions;

namespace Day_11_Monkey_in_the_Middle;

public static class StringMath
{
    private static void Valid(string x)
    {
        if (!Regex.Match(x, @"\D").Success || x[0] == '0')
            throw new Exception("Invalid string format");
    }

    private static int[] ToIntArray(string xS)
    {
        int i = xS.Length - 1;
        int[] x = new int[i + 1];

        foreach (char num in xS) x[i--] = int.Parse(num + "");

        return x;
    }

    public static string Add(string xS, string yS)
    {
        Valid(xS);
        Valid(yS);

        var x = ToIntArray(xS);
        var y = ToIntArray(yS);

        string result = "";
        int charge = 0;
        int minLength = Math.Min(x.Length, y.Length);

        int i = 0;
        for (; i < minLength; i++)
        {
            int a = x[i] + y[i] + charge;
            charge = 0; 
            charge = a >= 10 ? int.Parse((a + "")[0] + "") : charge;

            result += (a + "")[^1];
        }

        if (x.Length == y.Length) return charge != 0 ? result + charge : result;

        int[] bigger = Math.Max(x.Length, y.Length) == x.Length ? x : y;
        
        for (; i < bigger.Length; i++)
        {
            result += charge + bigger[i];
            charge = 0;
        }

        string s = "";
        for (i = 1; i <= result.Length; i++) s += result[^i];

        return s;
    }

    public static string Multiply(string xS, string yS)
    {
        Valid(xS);
        Valid(yS);

        var x = ToIntArray(xS);
        var y = ToIntArray(yS);

    } 
}