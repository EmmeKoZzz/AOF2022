using System.Text.RegularExpressions;

namespace Day_11_Monkey_in_the_Middle;

public static class StringMath
{
    private static void Valid(string x)
    {
        if (Regex.Match(x, @"\D").Success || x[0] == '0' || x.Length == 0)
            throw new Exception("Invalid string format");
    }

    private static int[] ToIntArray(string xS)
    {
        int[] x = new int[xS.Length];
        int i = 0;

        foreach (char num in xS) x[i++] = int.Parse(num + "");

        return x;
    }

    public static T[] Longer<T>(T[] arr1, T[] arr2) =>
        Math.Max(arr1.Length, arr2.Length) == arr1.Length ? arr1 : arr2;

    public static T[] Littest<T>(T[] arr1, T[] arr2) =>
        Math.Min(arr1.Length, arr2.Length) == arr1.Length ? arr1 : arr2;

    public static string ReverseString(string x)
    {
        string s = "";
        for (int i = 1; i <= x.Length; i++)
            s += x[^i];
        return s;
    }

    private static string Addition(int[] bigger, int[] lesser)
    {
        string result = "";
        int charge = 0;

        int i = 0;
        for (; i < lesser.Length; i++)
        {
            int a = bigger[i] + lesser[i] + charge;
            charge = 0;
            charge = a >= 10 ? int.Parse((a + "")[0] + "") : charge;

            result += (a + "")[^1];
        }

        if (bigger.Length == lesser.Length) return charge != 0 ? result + charge : result;

        for (; i < bigger.Length; i++)
        {
            result += charge + bigger[i];
            charge = 0;
        }

        return ReverseString(result);
    }

    public static string Sum(string xS, string yS)
    {
        Valid(xS);
        Valid(yS);

        var lesser = ToIntArray(ReverseString(xS));
        var bigger = ToIntArray(ReverseString(yS));

        (lesser, bigger) = (Littest(lesser, bigger), Longer(lesser, bigger));

        return Addition(bigger, lesser);
    }

    private static string MulOne(int[] x, int y)
    {
        string result = "";
        int charge = 0;
        foreach (int digit in x)
        {
            int product = digit * y + charge;
            charge = product >= 10 ? int.Parse((product + "")[0] + "") : 0;
            result += (product + "")[^1];
        }

        result += charge != 0 ? charge : "";

        return result;
    }

    public static string Multiply(string xS, string yS)
    {
        Valid(xS);
        Valid(yS);

        var lesser = ToIntArray(ReverseString(xS));
        var bigger = ToIntArray(ReverseString(yS));

        (lesser, bigger) = (Littest(lesser, bigger), Longer(lesser, bigger));

        var sumToMul = new string[lesser.Length];

        if (lesser.Length == 1) return ReverseString(MulOne(bigger, lesser[0]));

        for (int i = 0; i < lesser.Length; i++)
        {
            string zeros = "";
            for (int j = 0; j < i; j++) zeros += "0";

            sumToMul[i] = zeros + MulOne(bigger, lesser[i]);
        }

        string result = Addition(Longer(ToIntArray(sumToMul[0]), ToIntArray(sumToMul[1])),
            Littest(ToIntArray(sumToMul[0]), ToIntArray(sumToMul[1])));

        for (int i = 2; i < sumToMul.Length; i++)
            result = Addition(Longer(ToIntArray(result), ToIntArray(sumToMul[i])),
                Littest(ToIntArray(result), ToIntArray(sumToMul[i])));


        return result;
    }
}