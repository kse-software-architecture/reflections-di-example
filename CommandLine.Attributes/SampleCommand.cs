namespace CommandLine.Attributes;

[Command("sample")]
public class SampleCommand
{
    [Execute]
    public void Run()
    {
        Console.WriteLine("Sample Command Executed");
    }
}