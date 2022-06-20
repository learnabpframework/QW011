using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Amazing.Software;

public class SoftwareWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<SoftwareWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
