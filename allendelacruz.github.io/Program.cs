using allendelacruz.github.io.Common.Interfaces;
using allendelacruz.github.io.Common.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace allendelacruz.github.io
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<IJSUtilityService, JSUtilityService>();
            builder.Services.AddScoped<IDateTimeService, DateTimeService>();

            await builder.Build().RunAsync();
        }
    }
}