using System;
using Microsoft.Extensions.DependencyInjection;
using NetCore.Docker.Models;

namespace NetCore.Docker.Models

{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            if (services is null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            
        }
    }
}