using DependencyInjectionSample.Interfaces;

namespace DependencyInjectionSample.Services;

internal class MyDependency : IMyDependency
{
    public void WriteMessage(string msg)
    {
        Console.WriteLine($"MyDependency.WriteMessage called. Message is {msg}");
    }
}