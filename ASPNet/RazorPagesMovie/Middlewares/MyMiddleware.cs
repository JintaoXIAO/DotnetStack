using DependencyInjectionSample.Interfaces;

namespace RazorPagesMovie.Middlewares;

public class MyMiddleware
{
    private ILogger<MyMiddleware> _logger;
    private RequestDelegate _next;
    private IOperationSingleton _operationSingleton;

    public MyMiddleware(RequestDelegate next, ILogger<MyMiddleware> logger,
        IOperationSingleton operationSingleton)
    {
        _operationSingleton = operationSingleton;
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, IOperationTransient operationTransient,
        IOperationScoped operationScoped)
    {
        _logger.LogInformation("Transient: " + operationTransient.OperationId);
        _logger.LogInformation("Scoped: " + _operationSingleton.OperationId);
        _logger.LogInformation("Singleton: " + operationScoped.OperationId);

        await _next(context);
    }
}

public static class MyMiddlewareExtensions
{
    public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
    {
        builder.UseMiddleware<MyMiddleware>();
        return builder;
    }
}