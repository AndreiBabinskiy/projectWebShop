using Microsoft.AspNetCore.Builder;
using web1_1.Middleware;

namespace web1_1.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app)
        => app.UseMiddleware<LogMiddleware>();
    }
}
