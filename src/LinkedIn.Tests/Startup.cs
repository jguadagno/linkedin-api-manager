using System.Reflection;
using LinkedIn.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;

namespace LinkedIn.Tests;

public class Startup
{
    public void ConfigureHost(IHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureHostConfiguration(configurationBuilder =>
        {
            configurationBuilder //.SetBasePath(hostBuilder.HostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json", true)
                .AddJsonFile("appsettings.Development.json", true)
                .AddUserSecrets(Assembly.GetExecutingAssembly(), true)
                .AddEnvironmentVariables();
        });
        
        
    }

    public void ConfigureServices(IServiceCollection services, HostBuilderContext hostBuilderContext)
    {
        var config = hostBuilderContext.Configuration;
        services.AddSingleton(config);
        
        var linkedInApplicationSettings = new LinkedInApplicationSettings();
        config.Bind("LinkedIn", linkedInApplicationSettings);
        services.TryAddSingleton<ILinkedInApplicationSettings>(linkedInApplicationSettings);
        
        services.TryAddSingleton<ILinkedInManager, LinkedInManager>();

        services.AddHttpClient();
    }
}