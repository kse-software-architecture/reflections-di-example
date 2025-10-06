using System.Reflection;

// Default path is from /bin/Debug/net8.0, so here we need little hack to load from project folder
var dllPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "UserCommands.dll"));

var asm = Assembly.LoadFrom(dllPath);
foreach (var t in asm.GetTypes())
{
    Console.WriteLine(t.FullName);
}

// Get classes that are annotated with [Command]

// prepare dictionary of command types and keywords to invoke them

Console.WriteLine("Hello! Enter a command:");
var input = Console.ReadLine();
while (input != "exit")
{
    // parse input, find matching command, get method marked with Execute and invoke it.
    // Start with ones with no parameters
}