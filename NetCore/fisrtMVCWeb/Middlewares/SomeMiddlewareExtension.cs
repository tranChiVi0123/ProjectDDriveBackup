using Microsoft.AspNetCore.Builder;

public static class SomeMiddlewareExtensions
{
    public static IApplicationBuilder UseSimpleMiddeware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<SimpleMiddleware>();
    }
}