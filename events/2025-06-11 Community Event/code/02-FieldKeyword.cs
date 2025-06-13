namespace WhatsNewInDotnet10;

// Microsoft Docs:
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/field
public class FieldKeyword
{
    public int Length { get; set; }

    // Breaking change:
    // https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/breaking-changes/compiler%20breaking%20changes%20-%20dotnet%2010#expression-field-in-a-property-accessor-refers-to-synthesized-backing-field
    // https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/breaking-changes/compiler%20breaking%20changes%20-%20dotnet%2010#variable-named-field-disallowed-in-a-property-accessor
    private int field; // > What if: "field" is used as a variable name?
    public int LengthPositive
    {
        get;
        set => field = value > 0 ? value : 0;
    }
}
public class FieldKeywordEnd
{
    public int Length { get; set; }

    public int LengthPositive
    {
        get; // No body > automatically use "field"
        set => field = value > 0 ? value : 0;
    }
}
