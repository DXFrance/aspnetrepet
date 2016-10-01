using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication 
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(ctx =>
            {
                return ctx.Response.WriteAsync("Hello ASP.NET Core 1.0 #experiences");
            });
        }
    }
}