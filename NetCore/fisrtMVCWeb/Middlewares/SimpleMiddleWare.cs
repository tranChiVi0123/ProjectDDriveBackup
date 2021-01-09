using Microsoft.AspNetCore.Http;

public class SimpleMiddleware
{
    private readonly RequestDelegate _next;
    public SimpleMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async System.Threading.Tasks.Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("<h1>Hello Simple Middleware</h1>");
        await _next.Invoke(context);
        await context.Response.WriteAsync("<h1>Bye Simple Middleware</h1>");
    }
}