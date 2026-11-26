using System.Diagnostics;

namespace MVC01.MiddleWares
{
    public class RequestTimingMiddleware
    {
        private readonly RequestDelegate _next;
        public RequestTimingMiddleware(RequestDelegate next)
        {
            _next=next;
        }
        public async Task Invokeasync(HttpContext context)
        {
            var watch=Stopwatch.StartNew();
            await _next(context);
            watch.Stop();
            Console.WriteLine($"{context.Request.Path}==>{watch.ElapsedMilliseconds}ms");
        }
    }
}
