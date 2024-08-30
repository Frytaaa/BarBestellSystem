namespace Application;

public sealed class Table
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int X { get; set; }
    public int Y { get; set; }
}