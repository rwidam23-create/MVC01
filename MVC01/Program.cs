using MVC01.MiddleWares;
using static System.Net.Mime.MediaTypeNames;

namespace MVC01
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseMiddleware<RequestTimingMiddleware>();
            if (!app.Environment.IsDevelopment())
            {
                // Configure the HTTP request pipeline.
                //[1] Exception handling middleware
               
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //Tell the browser to use HTTPS for future requests
                //[2] HSTS --> HTTP STRICT TRANSPORT SECURITY
                app.UseHsts();
            }//[3] Redirect any incoming http request to https

            app.UseHttpsRedirection();
            //[4] Serve public assets / files [wwwroot]
            //app.UseStaticFiles();

            app.UseRouting();
            //[5] Match the incoming url with the available endpoints/actions
            //[6] Cross origin resource sharing
            //app.UseCors();
            //[7] Identifies who the current user is [login] [JWT , COOKIES]
            //app.UseAuthentication();

            //[8] Enable the app to read and write session data
            //app.UseSession();
            //app.Use(async (context, next) =>
            //{
            //    //before
            //    Console.WriteLine($"Hello");
            //    //next
            //    await next(context);
            //    //after
            //    Console.WriteLine($"Bye");
            //});

            //[9] Authenticated user is allowed to access resource
            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
            name: "shop",
            pattern: "{controller=Products}/{action=TestRouting}/{id:int?}"
             );
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
