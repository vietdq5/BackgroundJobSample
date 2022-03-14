using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace BackGroundJobDemo1;

public class BackGroundJobDemo1WebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<BackGroundJobDemo1WebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
