using DependencyInjectionSample.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private IOperationTransient _operationTransient;
    private IOperationScoped _operationScoped;
    private IOperationSingleton _operationSingleton;

    public IndexModel(ILogger<IndexModel> logger,
        IOperationTransient operationTransient,
        IOperationScoped operationScoped,
        IOperationSingleton operationSingleton)
    {
        _operationSingleton = operationSingleton;
        _operationScoped = operationScoped;
        _operationTransient = operationTransient;
        _logger = logger;
    }

    public void OnGet()
    {
        _logger.LogInformation("Transient: " + _operationTransient.OperationId);
        _logger.LogInformation("Scoped: " + _operationScoped.OperationId);
        _logger.LogInformation("Singleton: " + _operationSingleton.OperationId);
    }
}
