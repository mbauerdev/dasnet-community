namespace WhatsNewInDotnet9;

public static class Linq
{
    public static void Examples()
    {
        Lines("Count by country:");
        PrintDictionary(
            Cities
                .GroupBy(c => c.Country)
                .ToDictionary(
                    g => g.Key,
                    g => g.Count()));


        Lines();
        // TODO: Implement  

        Lines("Sum by country:");
        PrintDictionary(
            Cities
                .GroupBy(c => c.Country)
                .ToDictionary(
                    g => g.Key,
                    g => g.Sum(v => v.Population)));


        Lines();
        // TODO: Implement
        
        // Comment:
        // Already available before .NET 9:
        //  - MinBy
        //  - MaxBy
        
        // Would be nice to have a default implementation for every aggregation function, e.g.
        //  - AverageBy
        //  - etc.


        Lines("Index");
        foreach (City city in Cities.Take(10))
        {
            WriteLine($"Index: ???, Item: {city}");
        }
        
        // TODO: Implement
    }
    
    public static void ExamplesFinal()
    {
        Lines("Count by country:");
        PrintDictionary(
            Cities
                .GroupBy(c => c.Country)
                .ToDictionary(
                    g => g.Key,
                    g => g.Count()));


        Lines();
        PrintDictionary(
            Cities
                .CountBy(c => c.Country));


        Lines("Sum by country:");
        PrintDictionary(
            Cities
                .GroupBy(c => c.Country)
                .ToDictionary(
                    g => g.Key,
                    g => g.Sum(v => v.Population)));


        Lines();
        PrintDictionary(
            Cities
                .AggregateBy(
                    c => c.Country,
                    0,
                    (acc, c) => acc + c.Population));
        
        // Comment:
        // Already available before .NET 9:
        //  - MinBy
        //  - MaxBy
        
        // Would be nice to have a default implementation for every aggregation function, e.g.
        //  - AverageBy
        //  - etc.

        Lines("Index");
        foreach (City city in Cities.Take(10))
        {
            WriteLine($"Index: ???, Item: {city}");
        }
        
        foreach ((int index, City city) in Cities.Take(10).Index())
        {
            WriteLine($"Index: {index}, Item: {city}");
        }
    }

    private static readonly City[] Cities =
    [
        // Germany
        new("Berlin", "Germany", 3748148),
        new("Hamburg", "Germany", 1841179),
        new("Munich", "Germany", 1471508),
        new("Cologne", "Germany", 1085664),
        new("Frankfurt", "Germany", 753056),
        new("Stuttgart", "Germany", 634830),
        new("Düsseldorf", "Germany", 619294),
        new("Dortmund", "Germany", 588462),
        new("Essen", "Germany", 583109),
        new("Leipzig", "Germany", 587857),

        // Spain
        new("Madrid", "Spain", 3223334),
        new("Barcelona", "Spain", 1620343),
        new("Valencia", "Spain", 791413),
        new("Seville", "Spain", 688711),
        new("Zaragoza", "Spain", 674997),
        new("Málaga", "Spain", 574654),
        new("Murcia", "Spain", 447182),
        new("Palma", "Spain", 416065),
        new("Las Palmas", "Spain", 378517),
        new("Bilbao", "Spain", 345141),

        // Switzerland
        new("Zurich", "Switzerland", 434008),
        new("Geneva", "Switzerland", 201818),
        new("Basel", "Switzerland", 178302),
        new("Lausanne", "Switzerland", 139111),
        new("Bern", "Switzerland", 133115),
        new("Winterthur", "Switzerland", 114220),
        new("Lucerne", "Switzerland", 81592),
        new("St. Gallen", "Switzerland", 75522),
        new("Lugano", "Switzerland", 63185),
        new("Biel/Bienne", "Switzerland", 55445),

        // France
        new("Paris", "France", 2148327),
        new("Marseille", "France", 861635),
        new("Lyon", "France", 515695),
        new("Toulouse", "France", 479553),
        new("Nice", "France", 342522),
        new("Nantes", "France", 309346),
        new("Strasbourg", "France", 280966),
        new("Montpellier", "France", 277639),
        new("Bordeaux", "France", 252040),
        new("Lille", "France", 232787)
    ];

    static void PrintDictionary<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> dictionary)
    {
        foreach (var kvp in dictionary)
        {
            WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }

    record City(
        string Name,
        string Country,
        int Population);
}