using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Xmu.Crms.Shared.Scheduling;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class SchedulerExtensions
    {
        public static IServiceCollection AddScheduler(this IServiceCollection services) =>
            services.AddSingleton<IHostedService, SchedulerHostedService>();

        public static IServiceCollection AddScheduler(this IServiceCollection services,
            EventHandler<UnobservedTaskExceptionEventArgs> unobservedTaskExceptionHandler)
        {
            return services.AddSingleton<IHostedService, SchedulerHostedService>(serviceProvider =>
            {
                var instance = new SchedulerHostedService(serviceProvider.GetServices<IScheduledTask>());
                instance.UnobservedTaskException += unobservedTaskExceptionHandler;
                return instance;
            });
        }
    }
}