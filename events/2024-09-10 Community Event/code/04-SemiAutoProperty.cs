namespace WhatsNewInDotnet9;

public class SemiAutoProperty
{
    public int Length { get; set; }

    private int field;
    public int LengthPositive
    {
        get => field;
        set => field = value > 0 ? value : 0;
    }
}

// Example:
// https://sharplab.io/#v2:EYLgZgpghgLgrgJwgZwLTIgWwJaqnGAe1QAcFCTkAaAExAGoAfAAQCYBGAWACgfmBmAARtBAZSzYAggUIAFciQgIYATx4BvHoO3Ch2AHYxBAGQj6A5jAAWg9YPMQYAbkEZnggL48tOstgBusBCCBkZg2BAANjROPtoCIYYmZpZWsoTI2DABEHG2eTr2joIAvAB8guFRMQU6bqUVVdGlgoGRcMEVAAyCAPytUO3BIIJdsdyFXtweQA===
// public class SemiAutoProperty
// {
//     public int Length { get; set; }
//
//     public int LengthPositive
//     {
//         get => field;
//         set => field = value > 0 ? value : 0;
//     }
// }