namespace WhatsNewInDotnet9;

public static class ParamsCollections
{
    public static void Examples()
    {
        Print("Hello", "World");
    }
    
    // C# 2.0 (2005)
    public static void Print(params string[] values) => PrintInternal(values);
    // public static void Print(IEnumerable<string> values) => PrintInternal(values);
    
    // C# 9.0
    // TODO: Implement / try different interfaces
    
    public static void PrintInternal(IEnumerable<string> values)
    {
        foreach (var value in values)
        {
            WriteLine(value);
        }
    }
    
    public static void ExamplesFinal()
    {
        // Print("Hello", "World");
        //
        //
        // var values = new List<string> { "Hello", "World" };
        // Print(values);
        //
        // Print(["Hello", "World"]); // Uses the target expression type
    }
}