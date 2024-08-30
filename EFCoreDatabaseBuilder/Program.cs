// See https://aka.ms/new-console-template for more information

using Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

Console.WriteLine("Hello, World!");
string exePath = AppDomain.CurrentDomain.BaseDirectory;
string solutionPath = Directory.GetParent(exePath).Parent.Parent.Parent.Parent.FullName;
var dbPath = Path.Join(solutionPath, "bar.db");
var options = new DbContextOptionsBuilder<BarDbContext>().UseSqlite($"Data Source={dbPath}").Options;
var dbContext = new BarDbContext(options);

dbContext.Tables.Add(new Table { Name = "Table 1", X = 10, Y = 20 });
dbContext.Tables.Add(new Table { Name = "Table 2", X = 30, Y = 40 });
await dbContext.SaveChangesAsync();

public class ContextFactory : IDesignTimeDbContextFactory<BarDbContext>
{
    public BarDbContext CreateDbContext(string[] args)
    {
        string exePath = AppDomain.CurrentDomain.BaseDirectory;
        string solutionPath = Directory.GetParent(exePath).Parent.Parent.Parent.Parent.FullName;
        var dbPath = Path.Join(solutionPath, "bar.db");
        return new(new DbContextOptionsBuilder<BarDbContext>().UseSqlite($"Data Source={dbPath}").Options);
    }
}