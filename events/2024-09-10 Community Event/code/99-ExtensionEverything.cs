namespace WhatsNewInDotnet9;

// https://devblogs.microsoft.com/dotnet/csharp-13-explore-preview-features/#update-on-extension-types


// Could also be used as "alias"
using StringList = List<string>;
// using StringKeyedDictionary<T> = System.Collections.Generic.Dictionary<string, T>;
// public explicit extension StringKeyedDictionary<T> for System.Collections.Generic.Dictionary<string, T>;

public static class ExtensionEverything
{
    public static void Examples()
    {
        "Hello, World!".Left(3);
        // "Hello, World!".FirstLetter; // > How to do this?
        // string.EmptyButWithWhitespace // > How to do this?
    }

    public static string Left(this string source, int length)
        => source.Substring(
            0, 
            length > source.Length ? source.Length : length);


    // Syntax: how to do with Properties?
    
    // Syntax: how to define static extensions?
}


// public implicit extension StringExtension for string
// {
//     public static string Right(int length)
//         => this.Substring(
//             this.Length - length < 0 ? 0 : this.Length - length);
//     public string FirstLetter { get; }
//     public static string EmptyButWithWhitespace { get; }
//
// }