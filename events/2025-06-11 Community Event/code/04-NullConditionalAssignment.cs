namespace WhatsNewInDotnet10;

// Microsoft Docs:
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/null-conditional-assignment

public static class NullConditionalAssignment
{
    public static void Examples()
    {
        ParticipantCounter? counter = null;

        // Null-conditional access
        Console.WriteLine(counter?.Count);

        // Null-coalescing assignment
        counter ??= new ParticipantCounter { Count = 0 };

        // Reset counter
        if (counter is not null)
        {
            counter.Count = 0;
        }

        counter?.Count = 0;
        counter?.Count = 0;
        counter?.Count += 1;
        //counter?.Count++; // Not supported

    }


    public static void ExamplesFinal()
    {
        ParticipantCounter? counter = null;

        // Null-conditional access
        Console.WriteLine(counter?.Count);

        // Null-coalescing assignment
        counter ??= new ParticipantCounter { Count = 0 };

        // Reset counter
        if (counter is not null)
        {
            counter.Count = 0;
        }

        counter = null;
        counter?.Count = 0;
        counter?.Count += 1;
        //counter?.Count++; // Not supported > decision in a design meeting (https://github.com/dotnet/csharplang/blob/main/meetings/2024/LDM-2024-10-28.md#increment-and-decrement-operators-in-null-conditional-access)

        // ParticipantCounterStruct counterStruct = new();
        // counterStruct?.Count = 0; // Not supported > cannot use null-conditional access on a struct
    }
}

public class ParticipantCounter
{
    public int Count { get; set; }
}
public struct ParticipantCounterStruct
{
    public int Count { get; set; }
}
