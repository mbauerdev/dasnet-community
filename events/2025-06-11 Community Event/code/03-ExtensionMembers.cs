namespace WhatsNewInDotnet10;

// Microsoft Docs:
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/extensions
public static class ExtensionMembers
{
    public static void Examples()
    {
        _ = "Hello, World!".Left(3);
        // _ = "Hello, World!".Right(3);
        _ = "Hello, World!".FirstLetter; // > How to do this?
        _ = string.EmptyButWithWhitespace; // > How to do this?
        // _ = ((object)null).ToStringSafe(); // > How to do this?
    }

    public static string Left(this string source, int length)
        => source.Substring(
            0,
            length > source.Length ? source.Length : length);

    extension(string source)
    {
        public string Right(int length)
         => source.Substring(
             source.Length - length < 0 ? 0 : source.Length - length);

        public string FirstLetter => source.Length > 0 ? source.Substring(0, 1) : string.Empty;

        public static string EmptyButWithWhitespace => " "; // Cannot reference "source" > static

        // Operators (not supported in .NET 10 Preview 4)
        //public static string operator !(string str) => string.ToUpper();

    }
    //
    // extension(object? source)
    // {
    //     public string ToStringSafe() => source?.ToString() ?? string.Empty;
    // }
    //
    // extension<T>(List<T> source)
    // {
    //     public List<T> TakeFirst(int count)
    //         => source.Take(count).ToList();
    //
    //     public List<T> TakeLast(int count)
    //         => source.Skip(Math.Max(0, source.Count - count)).ToList();
    // }
}
