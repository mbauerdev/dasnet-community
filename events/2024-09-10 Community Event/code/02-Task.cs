namespace WhatsNewInDotnet9;

using static Helpers;

public static class TaskWhenEach
{
    public static async Task Examples()
    {
        // 1. Launch tasks
        Task<string>[] tasks =
        [
            DoStuff(1000),
            DoStuff(1000),
            DoStuff(2000),
            DoStuff(3000)
        ];
        
        // 2. Wait for completion
        await Task.WhenAll(tasks);
        
        // 3. Process results (safe access to result)
        foreach (var task in tasks)
        {
            WriteLine(task.Result);
        }
    }
    
    public static async Task ExamplesFinal()
    {
        // 1. Launch tasks
        Task<string>[] tasks =
        [
            DoStuff(1000),
            DoStuff(1000),
            DoStuff(2000),
            DoStuff(3000)
        ];
        
        // 2. Process whenever ready
        await foreach (Task<string> task in Task.WhenEach(tasks))
        {
            WriteLine(task.Result);
        }
    }

    private static async Task<string> DoStuff(int wait)
    {
        await Task.Delay(wait);
        return wait.ToString();
    }
}