using System;
using System.Collections.Generic;
using System.Text;
using Micro.Rabbit.Infra.Bus;
using MicroRabbit.Domain.Core.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //domain bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
