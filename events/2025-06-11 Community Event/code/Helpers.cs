using static System.Console;

namespace WhatsNewInDotnet10;

public static class Helpers
{
    extension(Console)
    {
        public static void WriteTitle(string message = "")
        {
            WriteLine(Environment.NewLine);
            if (!string.IsNullOrEmpty(message))
            {
                WriteLine(message);
            }

            WriteLine(new string('-', 50));
        }
    }
}
