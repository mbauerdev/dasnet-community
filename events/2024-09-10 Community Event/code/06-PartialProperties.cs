namespace WhatsNewInDotnet9;

public partial class PartialProperties
{
    public void Example()
    {
    }
}

public partial class PartialProperties
{
    //partial void PartialMethod() => throw new NotImplementedException();

    private int _partialProperty;
    public int PartialProperty___
    {
        // Some custom logic here...
        get => _partialProperty;
        set
        {
            WriteLine("Setting the value...");
            _partialProperty = value;
        }
    }
}

public partial class PartialPropertiesFinal
{
    public void Example()
    {
        PartialMethod(); // Show IL-code
        PartialProperty = 42;
    }
    
    partial void PartialMethod();
    public partial int PartialProperty { get; set; }
    
}

public partial class PartialPropertiesFinal
{
    // partial void PartialMethod() => throw new NotImplementedException();

    private int _partialProperty;
    public partial int PartialProperty
    {
        // Some custom logic here...
        get => _partialProperty;
        set
        {
            WriteLine("Setting the value...");
            _partialProperty = value;
        }
    }
}