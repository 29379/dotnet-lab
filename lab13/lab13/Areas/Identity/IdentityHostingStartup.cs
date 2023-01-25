using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(lab13.Areas.Identity.IdentityHostingStartup))]
namespace lab13.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}