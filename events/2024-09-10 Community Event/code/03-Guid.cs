namespace WhatsNewInDotnet9;

public partial class Guids
{
            
        
    // Comparison: https://datatracker.ietf.org/doc/html/rfc9562
    /*

     Version 4

         0                   1                   2                   3
         0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1
        +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
        |                           random_a                            |
        +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
        |          random_a             |  ver  |       random_b        |
        +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
        |var|                       random_c                            |
        +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
        |                           random_c                            |
        +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+

    Version 7

         0                   1                   2                   3
         0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1
        +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
        |                           unix_ts_ms                          |
        +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
        |          unix_ts_ms           |  ver  |       rand_a          |
        +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
        |var|                        rand_b                             |
        +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
        |                            rand_b                             |
        +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+

     */
    
    public static void Examples()
    {
        Lines("Random Guids...");

        for (int i = 0; i < 10; i++)
        {
            WriteLine(Guid.NewGuid());
        }

        Lines("V7 Guids...");
        Lines("V7 Guids with time-travel...");
    }
    
    public static void ExamplesFinal()
    {
        Lines("Random Guids...");

        for (int i = 0; i < 10; i++)
        {
            WriteLine(Guid.NewGuid());
        }

        Lines("V7 Guids...");
        for (int i = 0; i < 10; i++)
        {
            WriteLine(Guid.CreateVersion7());
        }

        Lines("V7 Guids with time-travel...");
        for (int i = 0; i < 10; i++)
        {
            WriteLine(Guid.CreateVersion7(DateTimeOffset.FromUnixTimeSeconds(0)));
        }    

    }
}