using System.Globalization;

namespace WhatsNewInDotnet10;

// Microsoft Docs:
// https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-10/libraries#numeric-ordering-for-string-comparison

// More info:
// Runtime:     https://github.com/dotnet/runtime/issues/110292
// Language:    https://github.com/dotnet/csharplang/discussions/8892
public static class NumericOrderingStrings
{
    public static void Examples()
    {
        string[] data = [
            "file1.txt",
            "file2.txt",
            "file10.txt",
            "file20.txt",
            "file3.txt",
            "file4.txt"
        ];

        data.Sort(StringComparer.Create(
            CultureInfo.InvariantCulture,
            CompareOptions.NumericOrdering));

        foreach (string str in data)
        {
            Console.WriteLine(str);
        }
    }

    public static void ExamplesFinal()
    {
        string[] data = [
            "file1.txt",
            "file2.txt",
            "file10.txt",
            "file20.txt",
            "file3.txt",
            "file4.txt"
        ];

        StringComparer comparer = StringComparer.Create(
            CultureInfo.InvariantCulture,
            CompareOptions.NumericOrdering);

        data.Sort(comparer);

        foreach (string str in data)
        {
            Console.WriteLine(str);
        }
    }
}
