using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Serilog;
namespace AspnetCoreWithSerilog.BuildingBlock
{
    public static class WebHostBuilderExtension
    {
        public static IWebHostBuilder UseDefaultLogger(this IWebHostBuilder webHostBuilder)
        {
            webHostBuilder.UseSerilog((ctx, cfg) => cfg.ReadFrom.ConfigurationSection(ctx.Configuration.GetSection("serilog")));
            return webHostBuilder;
        }
    }
}
