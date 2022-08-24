using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;


namespace BlazorWasmSyncStart
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Syncfusion components version: 20.2.0.40
            const string LICENSE_KEY = "Njg0Njg2QDMyMzAyZTMyMmUzMGxwUnNFZWh5VUZjZkV6MDhtV09HTi9DYitxRmF0TndmRFVEOXFBVjdpNUk9";
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