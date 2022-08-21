namespace Middleware.Example;

public class MiddlewareCustomizado
{
    private readonly RequestDelegate _next;
    protected readonly ILogger<Object> _logger;

    public MiddlewareCustomizado(RequestDelegate next, ILogger<object> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch(Exception ex)
        {
            _logger.LogError("Error: " + ex.Message);
        }       
    }
}