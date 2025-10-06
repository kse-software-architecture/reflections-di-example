namespace CommandLine.Attributes;

public class CommandAttribute(string name) : Attribute
{
    public string Name { get; set; } = name;
}

public class ExecuteAttribute : Attribute
{
}