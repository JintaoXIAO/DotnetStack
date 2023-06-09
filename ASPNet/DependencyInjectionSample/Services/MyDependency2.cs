using DependencyInjectionSample.Interfaces;
using Microsoft.Extensions.Logging;

namespace DependencyInjectionSample.Services;

internal class MyDependency2 : IMyDependency
{
    private ILogger<MyDependency2> _logger;

    public MyDependency2(ILogger<MyDependency2> logger)
    {
        _logger = logger;
    }
    
    public void WriteMessage(string msg)
    {
        _logger.LogInformation($"MyDependency2.WriteMessage Message: {msg}");
    }
}