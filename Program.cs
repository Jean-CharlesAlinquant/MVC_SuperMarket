using System.Net.Mime;
using System.Text;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(); // Provide access to wwwroot files

app.UseRouting();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// app.MapGet("/", () => "Hello World!");
// app.MapGet("/", (HttpContext context) =>
// {
//     string html = @"<html>
//                         <body>
//                             <h1>Hello World!</h1>
//                             <br/>
//                             Welcome to this new world!
//                         </body>
//                     </html>";
//     WriteHtml(context, html);
// });

// app.Run();

// void WriteHtml(HttpContext context, string html)
// {
//     context.Response.ContentType = MediaTypeNames.Text.Html;
//     context.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
//     context.Response.WriteAsync(html);
// }