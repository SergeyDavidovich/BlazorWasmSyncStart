using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;


namespace BlazorWasmSyncStart
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Syncfusion components version: 20.3.0.52
            const string LICENSE_KEY = "NzU1NzY3QDMyMzAyZTMzMmUzMGhTL1Z4aTVGcFJjTkJrR2xuaGVIcjdBSXcyTDVBK1RFdzNPRURqQTJZc2M9";
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(LICENSE_KEY);

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });

            await builder.Build().RunAsync();
        }
    }
}