namespace WhatsNewInDotnet9;

public static class Helpers
{
    public static void Lines(string message = "")
    {
        WriteLine(Environment.NewLine);
        if (!string.IsNullOrEmpty(message))
        {
            WriteLine(message);
        }
        WriteLine(new string('-', 50));
    }
}